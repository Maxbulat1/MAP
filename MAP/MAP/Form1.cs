using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 1";
            NameLandmark.Text = "Avenida Rudge";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 200);
            PanelEnergyBars.Location = new Point(34, 260);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = false;
            PanelInformation.Visible = false;
            PanelMedical.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 2";
            NameLandmark.Text = "Theatro Municipal";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 136);
            PanelEnergyBars.Location = new Point(34, 192);
            PanelToilets.Location = new Point(34, 248);
            PanelInformation.Location = new Point(34, 304);
            PanelMedical.Location = new Point(34, 360);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = true;
            PanelMedical.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 3";
            NameLandmark.Text = "Parque do Ibirapuera";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 180);
            PanelEnergyBars.Location = new Point(34, 240);
            PanelToilets.Location = new Point(34, 300);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = false;
            PanelMedical.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 4";
            NameLandmark.Text = "Jardim Luzitania";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 160);
            PanelEnergyBars.Location = new Point(34, 220);
            PanelToilets.Location = new Point(34, 280);
            PanelMedical.Location = new Point(34, 340);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = false;
            PanelMedical.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 5";
            NameLandmark.Text = "Iguatemi";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 160);
            PanelEnergyBars.Location = new Point(34, 220);
            PanelToilets.Location = new Point(34, 280);
            PanelInformation.Location = new Point(34, 340);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = true;
            PanelMedical.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 6";
            NameLandmark.Text = "Rua Lisboa";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 180);
            PanelEnergyBars.Location = new Point(34, 240);
            PanelToilets.Location = new Point(34, 300);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = false;
            PanelMedical.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 7";
            NameLandmark.Text = "Cimeterio da Consolacao";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 136);
            PanelEnergyBars.Location = new Point(34, 192);
            PanelToilets.Location = new Point(34, 248);
            PanelInformation.Location = new Point(34, 304);
            PanelMedical.Location = new Point(34, 360);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = true;
            PanelMedical.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Изменение имён
            NameCheckPoint.Text = "CheckPoint 8";
            NameLandmark.Text = "Cimeterio da Consolacao";

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 7);
            NameLandmark.Location = new Point(5, 70);

            //Локация Панелей
            PanelDrinks.Location = new Point(34, 136);
            PanelEnergyBars.Location = new Point(34, 192);
            PanelToilets.Location = new Point(34, 248);
            PanelInformation.Location = new Point(34, 304);
            PanelMedical.Location = new Point(34, 360);

            //Отключение Панелей
            PanelDrinks.Visible = true;
            PanelEnergyBars.Visible = true;
            PanelToilets.Visible = true;
            PanelInformation.Visible = true;
            PanelMedical.Visible = true;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 136);
            NameLandmark.Location = new Point(5, 192);

            //Изменение имён
            NameCheckPoint.Text = "Race Start";
            label7.Text = "";
            label1.Text = "";
            NameLandmark.Text = "Jongo Start Marathon";

            //Отключение Панелей
            PanelDrinks.Visible = false;
            PanelEnergyBars.Visible = false;
            PanelToilets.Visible = false;
            PanelInformation.Visible = false;
            PanelMedical.Visible = false;
        }

        private void Start2_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 136);
            NameLandmark.Location = new Point(5, 192);

            //Изменение имён
            NameCheckPoint.Text = "Race Start";
            label7.Text = "";
            label1.Text = "";
            NameLandmark.Text = "Jongo Half Marathon";

            //Отключение Панелей
            PanelDrinks.Visible = false;
            PanelEnergyBars.Visible = false;
            PanelToilets.Visible = false;
            PanelInformation.Visible = false;
            PanelMedical.Visible = false;
        }

        private void Start3_Click(object sender, EventArgs e)
        {
            //Видимость панели
            panel1.Visible = true;

            //Локация Названий
            NameCheckPoint.Location = new Point(5, 136);
            NameLandmark.Location = new Point(5, 192);

            //Изменение имён
            NameCheckPoint.Text = "Race Start";
            label7.Text = "";
            label1.Text = "";
            NameLandmark.Text = "Jongo Finish Marathon";

            //Отключение Панелей
            PanelDrinks.Visible = false;
            PanelEnergyBars.Visible = false;
            PanelToilets.Visible = false;
            PanelInformation.Visible = false;
            PanelMedical.Visible = false;
        }
    }
}
