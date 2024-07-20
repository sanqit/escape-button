namespace EscapeButton;

public partial class MainForm : Form
{
    private readonly Random _rnd = new();
    public MainForm() => InitializeComponent();

    private void YesButton_Click(object sender, EventArgs e) =>
        MessageBox.Show(@"Мы всегда знали что вам нравится!");

    private void NoButton_Click(object sender, EventArgs e) =>
        MessageBox.Show(@"Да вы сверхчеловек!!");

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
        //MoveButtonFurtherAwayIfNeed(YesButton, e.Location, 30);
        MoveButtonFurtherAwayIfNeed(NoButton, e.Location, 50);
    }

    private void MoveButtonFurtherAwayIfNeed(Button button, Point cursorLocation, int minDistance)
    {
        if (HasCursorMovedCloser(button, cursorLocation, minDistance, out var restrictedCursorButtonArea))
        {
            button.Location = new Point(_rnd.Next(Width - restrictedCursorButtonArea.Width), _rnd.Next(Height - restrictedCursorButtonArea.Height));
        }
    }

    private static bool HasCursorMovedCloser(Button button, Point cursorLocation, int minDistance, out Rectangle restrictedCursorButtonArea)
    {
        restrictedCursorButtonArea = new Rectangle(
            button.Location.X - minDistance,
            button.Location.Y - minDistance,
            button.Size.Width + 2 * minDistance,
            button.Size.Height + 2 * minDistance
        );

        return restrictedCursorButtonArea.IntersectsWith(new Rectangle(cursorLocation, new Size(0, 0)));
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
        var keys = new[] { Keys.Left, Keys.Right, Keys.Up, Keys.Down };
        return keys.Contains(keyData) || base.ProcessDialogKey(keyData);
    }
}