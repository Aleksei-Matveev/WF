using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Lab_01
{
    class Window
    {
        public void Run()
        {
            Form form = new Form();
            form.Size = new Size(800, 600);
           
            Application.Run(form);
        }
    }
}
