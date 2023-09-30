namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbTypeFurniture.Items.Add("Wooden Furniture");
            cbTypeFurniture.Items.Add("Metal Furniture");
        }

        private void btStart1_Click(object sender, EventArgs e)
        {

            string selectedItem = cbTypeFurniture.SelectedItem?.ToString();

            FurnitureFactory factory;
            Furniture chair, table;

            if (selectedItem == "Wooden Furniture")
            {
                factory = new WoodenFurnitureFactory();
                chair = factory.CreateChair();
                table = factory.CreateTable();
            }
            else if (selectedItem == "Metal Furniture")
            {
                factory = new MetalFurnitureFactory();
                chair = factory.CreateChair();
                table = factory.CreateTable();
            }
            else
            {
                return;
            }
            txtInformation1.AppendText(chair.Assemble() + "\n" + Environment.NewLine);
            txtInformation1.AppendText(table.Assemble() + "\n" + Environment.NewLine);



            chair.Assemble();
            table.Assemble();
        }


        private void btLib1_Click(object sender, EventArgs e)
        {
            Component component = new ConcreteComponent();
            Decorator decoratorA = new ConcreteDecoratorA(component);
            Decorator decoratorB = new ConcreteDecoratorB(decoratorA);

            txtInformation2.AppendText(decoratorA.Display() + "\n" + Environment.NewLine);
            txtInformation2.AppendText(decoratorB.Display() + "\n" + Environment.NewLine);

        }

        private void btStart3_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            Interpreter parser = ParseExpression(input);
            int result = parser.Interpret();
            txtOutput.Text = "Result: " + result.ToString();

        }
        private Interpreter ParseExpression(string expression)
        {
           
            string[] tokens = expression.Split('+');

            if (tokens.Length == 2)
            {
                Interpreter left = new NumberInterpreter(int.Parse(tokens[0].Trim()));
                Interpreter right = new NumberInterpreter(int.Parse(tokens[1].Trim()));
                return new AdditionInterpreter(left, right);
            }
            else
            {
                throw new ArgumentException("Invalid expression.");
            }
        }
    }
}