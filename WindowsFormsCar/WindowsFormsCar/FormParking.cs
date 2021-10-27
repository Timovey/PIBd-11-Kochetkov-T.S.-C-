using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCar
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width,
            pictureBoxParking.Height);
        }
        /// <summary>         
        /// Заполнение listBoxLevels         
        /// </summary>         
        private void ReloadLevels()         {             
            int index = listBoxParkings.SelectedIndex;

        listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)             
            {                 
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);             
            } 
 
            if(listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))             
            { 
                listBoxParkings.SelectedIndex = 0;             
            }             

            else if (listBoxParkings.Items.Count > 0 && index > -1 && index<listBoxParkings.Items.Count)             {                 
                listBoxParkings.SelectedIndex = index;         
            }
        } 
 
 

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary>   
        /// Обработка нажатия кнопки "Добавить парковку"         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void buttonAddParking_Click(object sender, EventArgs e)         {             
            if(string.IsNullOrEmpty(textBoxNewLevelName.Text))             
            {                 
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                return;             
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text); ReloadLevels();
        }

        /// <summary>         
        /// Обработка нажатия кнопки "Удалить парковку"          
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void buttonDelParking_Click(object sender, EventArgs e)         
        {             
            if (listBoxParkings.SelectedIndex > -1)             
            {                 
                if(MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)      
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());                     
                    ReloadLevels();                 
                }             
            }         
        }



        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Car(100, 1000, dialog.Color);
                    if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + car)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
				}
			}
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCrawlerCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new CrawlerCar(100, 1000, dialog.Color, dialogDop.Color,
                       true, true, true);
                        if (parkingCollection[listBoxParkings.SelectedItem.ToString()] + car)
                        {
                            Draw();
                        }
                        else
                        {
                            MessageBox.Show("Парковка переполнена");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var car = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    FormCar form = new FormCar();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>    
        /// Метод обработки выбора элемента на listBoxLevels         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)         {
            Draw();        
        }   
    }
}
