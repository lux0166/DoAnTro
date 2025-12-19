namespace QuanLyNhaTro.Core.Interfaces
{
    public interface ILoginView
    {
        string TenDangNhap { get; }
        string MatKhau { get; }

        void ShowMessage(string message, string caption, bool isError = false);
        void LoginSuccess();
        void CloseView();
    }
}
