OpenFileDialog openDialog = new OpenFileDialog();
openDialog.Title = "Select A File";
openDialog.Filter = "Text Files (*.txt)|*.txt" + "|" + 
                    "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                    "All Files (*.*)|*.*";
if (openDialog.ShowDialog() == DialogResult.OK)
{
    string file = openDialog.FileName;
}
