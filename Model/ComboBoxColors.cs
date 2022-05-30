namespace OOP8.Model
{
    internal class ComboBoxColors
    {
        private Color[] _colors;
        private ComboBox[] _comboBoxes;

        public ComboBoxColors(params ComboBox[] checkBoxes)
        {
            _comboBoxes = checkBoxes;
            _colors = new Color[]
            {
                Color.White,
                Color.Black,
                Color.Blue,
                Color.Green,
                Color.Orange,
                Color.Purple
            };
        }

        public void Work()
        {
            foreach (var comboBox in _comboBoxes)
            {
                comboBox.Items.AddRange(_colors.Select(color => (object)color).ToArray());
            }
        }
    }
}
