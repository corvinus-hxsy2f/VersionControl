﻿using PoC.Entities;
using PoC.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace PoC
{
    public partial class Form1 : Form
    {

        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> currencies = new BindingList<string>();


        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = currencies;
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetCurrenciesRequestBody();
            var response = mnbService.GetCurrencies(request);
            string result = response.GetCurrenciesResult;
            XmlDocument vxml = new XmlDocument();
            vxml.LoadXml(result);

            foreach (XmlElement item in vxml.DocumentElement.FirstChild.ChildNodes)
            {
                currencies.Add(item.InnerText);
            }

            RefreshData();
        }

        private void RefreshData()
        {
            if (comboBox1.SelectedItem == null) return;
            Rates.Clear();
            string xmlstring = GetWebService();
            LoadXML(xmlstring);
            dataGridView1.DataSource = Rates;
            Charting();
        }

        private void LoadXML(string input)
        {
            var xml = new XmlDocument();
            xml.LoadXml(input);

            foreach (XmlElement element in xml.DocumentElement)
            {
               
                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private string GetWebService()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = comboBox1.SelectedItem.ToString(),
                startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd")
            };
            var response = mnbService.GetExchangeRates(request);
            string result = response.GetExchangeRatesResult;
            return result;
        }

        public void Charting()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }


        private void filterChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
