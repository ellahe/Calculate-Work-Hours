using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using WorkHourCalculator.Domain;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace WorkHourCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
            var list = new List<IntTitleDTO>();
            list.Add(new IntTitleDTO((int)WeekDay.Saturday, WeekDay.Saturday.GetEnumDescription()));
            list.Add(new IntTitleDTO((int)WeekDay.Sunday, WeekDay.Sunday.GetEnumDescription()));
            list.Add(new IntTitleDTO((int)WeekDay.Monday, WeekDay.Monday.GetEnumDescription()));
            list.Add(new IntTitleDTO((int)WeekDay.Tuesday, WeekDay.Tuesday.GetEnumDescription()));
            list.Add(new IntTitleDTO((int)WeekDay.Wednesday, WeekDay.Wednesday.GetEnumDescription()));
            list.Add(new IntTitleDTO((int)WeekDay.Thursday, WeekDay.Thursday.GetEnumDescription()));
            list.Add(new IntTitleDTO((int)WeekDay.Friday, WeekDay.Friday.GetEnumDescription()));
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = nameof(IntTitleDTO.Title);
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excelPackage = new ExcelPackage();
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("WorkHour");
            var counter = 1;
            worksheet.Cells["A" + counter.ToString()].Value = "Date";
            worksheet.Cells["B" + counter.ToString()].Value = "Weekday";
            worksheet.Cells["C" + counter.ToString()].Value = "Start1";
            worksheet.Cells["D" + counter.ToString()].Value = "End1";
            worksheet.Cells["E" + counter.ToString()].Value = "Start2";
            worksheet.Cells["F" + counter.ToString()].Value = "End2";
            worksheet.Cells["G" + counter.ToString()].Value = "Start3";
            worksheet.Cells["H" + counter.ToString()].Value = "End3";
            worksheet.Cells["I" + counter.ToString()].Value = "CalculateHours";
            counter++;
            var data = gridControl1.DataSource as List<WeekDayHour>;
            data.Where(x => x.Start1.Start != string.Empty);
            foreach (var item in data)
            {
                worksheet.Cells["A" + counter.ToString()].Value = item.Date.ToString();
                worksheet.Cells["B" + counter.ToString()].Value = item.WeekDay;
                worksheet.Cells["C" + counter.ToString()].Value = item.Start1.Start;
                worksheet.Cells["D" + counter.ToString()].Value = item.Start1.End;
                worksheet.Cells["E" + counter.ToString()].Value = item.Start2.Start;
                worksheet.Cells["F" + counter.ToString()].Value = item.Start2.End;
                worksheet.Cells["G" + counter.ToString()].Value = item.Start3.Start;
                worksheet.Cells["H" + counter.ToString()].Value = item.Start3.End;
                worksheet.Cells["I" + counter.ToString()].Value = item.CalculateHours;
                counter++;
            }
            worksheet.View.RightToLeft = true;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "WorkHour.xlsx");
            excelPackage.SaveAs(new FileInfo(filePath));

            Console.WriteLine("Excel file saved to desktop.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GenerateData();
        }

        private void GenerateData()
        {
            var weekday = (comboBox1.SelectedItem as IntTitleDTO ?? new IntTitleDTO(0, string.Empty)).ID;
            List<WeekDayHour> dataSource = new List<WeekDayHour>();
            for (int i = 0; i < 30; i++)
            {
                dataSource.Add(new WeekDayHour()
                {
                    Date = dateTimePicker.Value.AddDays(i),
                    WeekDay = ((WeekDay)weekday).GetEnumDescription()
                });
                weekday++;
                if (weekday == 7)
                    weekday = 0;
            }

            gridControl1.DataSource = dataSource;
        }

        private void LoadData()
        {
            LoadExcel();
        }

        public void LoadExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "WorkHour.xlsx");

            if (File.Exists(filePath))
            {
                List<WeekDayHour> people = new List<WeekDayHour>();

                FileInfo file = new FileInfo(filePath);
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        WeekDayHour weekDayHour = new WeekDayHour();

                        weekDayHour.Date = DateTime.Parse(worksheet.Cells[row, 1].Value?.ToString()); 
                        weekDayHour.WeekDay = worksheet.Cells[row, 2].Value?.ToString(); 
                        weekDayHour.Start1.Start = worksheet.Cells[row, 3].Value.ToString();
                        weekDayHour.Start1.End = worksheet.Cells[row, 4].Value.ToString();
                        weekDayHour.Start2.Start = worksheet.Cells[row, 5].Value.ToString();
                        weekDayHour.Start2.End = worksheet.Cells[row, 6].Value.ToString();
                        weekDayHour.Start3.Start = worksheet.Cells[row, 7].Value.ToString();
                        weekDayHour.Start3.End = worksheet.Cells[row, 8].Value.ToString();
                        people.Add(weekDayHour);
                    }
                }
                gridControl1.DataSource = people;
                CalculateHoursAndMinutes();
                btnGenerateExcel.Enabled = false;
                btnGenerateExcel.Text = "در دسکتاپ موجود است WorkHour  فایل اکسل بنام";
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CalculateHoursAndMinutes();
        }

        private void CalculateHoursAndMinutes()
        {
            int totalHours = 0;
            int totalMinutes = 0;
            gridControl1.Update();
            var data = gridControl1.DataSource as List<WeekDayHour>;
            foreach (var time in data.Where(y => y.CalculateMinutes != "0").Select(x => x.CalculateMinutes))
            {
                totalMinutes += int.Parse(time);
            }

            totalHours += totalMinutes / 60;
            txtTotalHour.Text = totalHours.ToString() + ":" + (totalMinutes % 60).ToString();
            txtTotalMinites.Text = totalMinutes.ToString();
        }

    }
}



