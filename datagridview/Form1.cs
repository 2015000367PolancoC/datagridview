namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void llenar()
        {
            string path = @"C:\Users\LABORATORIO\Pictures\";
            Image imagen1 = Image.FromFile(path + "foto.jpg");

            object[] fila0 = { imagen1,
                "Alfons Gonzalez Perez", "Argentona, Barcelona","93333333",true
            };
            object[] fila1 = { imagen1,
                "Ana Maria Cuesta Suñer", "Gijon, Asturias","98445454",true
            };
            object[] fila2 = { imagen1,
                "Elena Veiguela Suarez", "Pontevedra","986678678",true
            };
            object[] fila3 = { imagen1,
                "Nicole Estefania Xiruj", "Montserrat","35219297",false
            };

            Tabla2.Rows.Add(fila0);
            Tabla2.Rows.Add(fila1);
            Tabla2.Rows.Add(fila2);
            Tabla2.Rows.Add(fila3);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenar();
        }
    }
}
