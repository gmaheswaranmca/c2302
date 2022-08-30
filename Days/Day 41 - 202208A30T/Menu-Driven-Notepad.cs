private void MnuNew_Click(object sender, EventArgs e)
{
	TxtDoc.Text = string.Empty;
}

private void MnuExit_Click(object sender, EventArgs e)
{
	this.Close();
}

private void MnuOpen_Click(object sender, EventArgs e)
{
	DlgOpen.ShowDialog();//Pick the folder and pick the file name 
	TxtDoc.LoadFile(DlgOpen.FileName);//The doc chosen by dialogue is opened
}

private void MnuSave_Click(object sender, EventArgs e)
{
	DlgSave.ShowDialog();//Pick the folder and give the file name 
	TxtDoc.SaveFile(DlgSave.FileName);//"Path+FileName" in the DlgSave.FileName
	MessageBox.Show("File is saved");
}

private void MnuColor_Click(object sender, EventArgs e)
{
	DlgColor.ShowDialog();
	//TxtDoc.ForeColor = DlgColor.Color;
	TxtDoc.SelectionColor = DlgColor.Color;
}

private void MnuFont_Click(object sender, EventArgs e)
{
	DlgFont.ShowDialog();
	//TxtDoc.Font = DlgFont.Font;
	TxtDoc.SelectionFont = DlgFont.Font;
}