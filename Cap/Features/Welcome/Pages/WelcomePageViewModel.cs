using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap
{
    public class WelcomePageViewModel : BaseModel
    {

        public WelcomePageViewModel()
        {
            WelcomeModel item1 = new()
            {
                Title = "Chào mừng bạn đến với Chick & Paddy",
                HelpText = "CAP (Chick & Paddy) là công cụ thông mình hỗ trợ các cặp đôi sáng tạo, lưu giữ và quản lý những khoảnh khắc bên nhau.",
                BackGroundImageSource = "background_welcome1.svg",
                ImageSource = "welcome_image1.svg",
                IsShow1 = true,
                IsShow2 = false,
                MarginImage = new Thickness(100,110,100,41)
            };
            CarouselItems.Add(item1);
            WelcomeModel item2 = new()
            {
                Title = "Sáng tạo bài viết, hình ảnh, video",
                HelpText = "Bạn có thể dễ dàng tạo bài viết,album, video lưu giữ nhưng kỉ niệm của 2 người",
                BackGroundImageSource = "background_welcome2.svg",
                ImageSource = "welcome_image2.svg",
                IsShow1 = false,
                IsShow2 = true,
                MarginImage = new Thickness(48, 0)
            };
            CarouselItems.Add(item2);
            WelcomeModel item3 = new()
            {
                Title = "Trò chuyện riêng tư, bảo mật tuyệt đối",
                HelpText = "Bạn chỉ trò chuyện với một người duy nhất trong CAP, riêng tư, thoải mái, bảo mật",
                BackGroundImageSource = "background_welcome1.svg",
                ImageSource = "welcome_image3.svg",
                IsShow1 = true,
                IsShow2 = false,
                MarginImage = new Thickness(78, 0)
            };
            CarouselItems.Add(item3);
            WelcomeModel item4 = new()
            {
                Title = "Kho couple game với hơn 1000 game",
                HelpText = "Bạn chỉ trò chuyện với một người duy nhất trong CAP, riêng tư, thoải mái, bảo mật",
                BackGroundImageSource = "background_welcome2.svg",
                ImageSource = "welcome_image4.svg",
                IsShow1 = false,
                IsShow2 = true,
                MarginImage = new Thickness(68,100,68,0)
            };
            CarouselItems.Add(item4);
        }
        public ObservableCollection<WelcomeModel> CarouselItems { get; set; } = new ObservableCollection<WelcomeModel>();
        public string TextButon1 { get; set; } = "Tiếp tục";
        public string TextButon2 { get; set; } = "Bỏ qua";
    }
}
