using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Data;
using QuanLyNhaTro.Models;

namespace QuanLyNhaTro.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly NguoiDungRepository _repository;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
            _repository = new NguoiDungRepository();
        }

        public void Login()
        {
            string username = _view.TenDangNhap;
            string password = _view.MatKhau;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _view.ShowMessage("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", isError: true);
                return;
            }

            NguoiDung user = _repository.GetByUsername(username);

            if (user == null)
            {
                _view.ShowMessage("Tên đăng nhập không tồn tại.", "Lỗi Đăng nhập", isError: true);
                return;
            }

            // Securely verify the password using BCrypt
            if (BCrypt.Net.BCrypt.Verify(password, user.MatKhau))
            {
                if (user.TrangThai)
                {
                    _view.ShowMessage("Đăng nhập thành công!", "Thành công");
                    _view.LoginSuccess();
                    _view.CloseView();
                }
                else
                {
                    _view.ShowMessage("Tài khoản của bạn đã bị khóa.", "Lỗi Đăng nhập", isError: true);
                }
            }
            else
            {
                _view.ShowMessage("Mật khẩu không chính xác.", "Lỗi Đăng nhập", isError: true);
            }
        }
    }
}
