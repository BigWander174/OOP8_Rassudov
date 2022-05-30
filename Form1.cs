using OOP8.Model;
using OOP8.Model.PointAdders;
using OOP8.View;

namespace OOP8
{
	public partial class Form1 : Form
	{
		private ComboBox[] _comboBoxes;
		private RadioButton[] _radioButtons;

		private FiguresHistory _figuresHistory;
		private Drawing _drawing;
		private Pointers _pointers;
		private Graphics _graphics;
		private Creator _creator;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_graphics = Canvas.CreateGraphics();
			
			_comboBoxes = new ComboBox[] { lineColor, backColor, fillColor };
			
			dGVHistory.ColumnCount = 2;

			var colorFiller = new ComboBoxColors(_comboBoxes);

			colorFiller.Work();

			_radioButtons = new RadioButton[]
			{
				radioButton1,
				radioButton2,
				radioButton3,
			};

			_drawing = new Drawing(_graphics);
			_creator = new Creator();
			_figuresHistory = new FiguresHistory(_creator);
			_pointers = new Pointers(_drawing, _creator, _figuresHistory, radioButton4, radioButton5);
			var history = new History(dGVHistory, _creator);
			var drawer = new Drawer(_creator);
		}

		private void backColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			var box = (ComboBox)sender;
			var color = (Color) box.SelectedItem;
			_graphics.Clear(color);
			_figuresHistory.Draw();
		}

		private void lineColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			_drawing.SetPenColor(sender);
		}

		private void Canvas_MouseClick(object sender, MouseEventArgs e)
		{
			_pointers.Work(e.Location);
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			var radio = (RadioButton)sender;

			var index = Array.IndexOf(_radioButtons, radio);
			_drawing.SetFigure(index);
		}

		private void fillColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			_drawing.SetBrush(sender);
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			_pointers.Set(sender);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int index = dGVHistory.SelectedRows[0].Index;
			_creator.FigureRemoved.Invoke(index);
			_graphics.Clear((Color)backColor.SelectedItem);
			_figuresHistory.Draw();
		}
	}
}