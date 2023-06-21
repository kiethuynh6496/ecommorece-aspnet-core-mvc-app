using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "CGV",
                            Logo = "https://gigamall.com.vn/data/2019/05/06/11365490_logo-cgv-500x500.jpg",
                            Description = "CGV"
                        },
                        new Cinema()
                        {
                            Name = "Galaxy Cinema",
                            Logo = "https://www.galaxycine.vn/website/images/galaxy-logo-mobile.png",
                            Description = "Galaxy Cinema"
                        },
                        new Cinema()
                        {
                            Name = "Lotte Cinema",
                            Logo = "https://www.lottecinemavn.com/LCCS/Image/thum/img_outline01_1.jpg",
                            Description = "Lotte Cinema"
                        },
                        new Cinema()
                        {
                            Name = "BHD Star Cineplex",
                            Logo = "https://www.bhdstar.vn/wp-content/uploads/2019/06/BHDStar_Logo_Tron.png",
                            Description = "BHD Star Cineplex"
                        },
                        new Cinema()
                        {
                            Name = "CineStar",
                            Logo = "https://cinestar.com.vn/pictures/400x400.png",
                            Description = "CineStar"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Thái Hòa",
                            Bio = "Thái Hòa",
                            ProfilePictureURL = "https://tieusu.com/wp-content/uploads/2022/06/tieu-su-Thai-hoa-1.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Ngô Thanh Vân",
                            Bio = "Ngô Thanh Vân",
                            ProfilePictureURL = "https://vcdn1-giaitri.vnecdn.net/2023/03/14/ngothanhvantop-1678779277-1370-1678780532.jpg?w=500&h=300&q=100&dpr=2&fit=crop&s=VdCT7qjVgmEyabr8hJoY0A"
                        },
                        new Actor()
                        {
                            FullName = "Ninh Dương Lan Ngọc",
                            Bio = "Ninh Dương Lan Ngọc",
                            ProfilePictureURL = "https://images2.thanhnien.vn/528068263637045248/2023/4/14/edit-lan-ngoc--1681439195640898341745.png"
                        },
                        new Actor()
                        {
                            FullName = "Kiều Minh Tuấn",
                            Bio = "Kiều Minh Tuấn",
                            ProfilePictureURL = "https://images2.thanhnien.vn/Uploaded/thanhlongn/2022_05_16/kieu-minh-tuan-9-7924.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Kaity Nguyễn",
                            Bio = "Kaity Nguyễn",
                            ProfilePictureURL = "https://images2.thanhnien.vn/528068263637045248/2023/3/6/tnh5761-1678067038624102703936.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Trấn Thành",
                            Bio = "Trấn Thành",
                            ProfilePictureURL = "https://yt3.googleusercontent.com/ytc/AGIKgqPnGjkhAi0wRgcuhFbY7gtC_fTIhZONLCuGRO-K2Q=s900-c-k-c0x00ffffff-no-rj"

                        },
                        new Producer()
                        {
                            FullName = "Victor Vũ",
                            Bio = "Victor Vũ",
                            ProfilePictureURL = "https://www.elle.vn/wp-content/uploads/2014/04/16/VictorVu1Custom.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Nguyễn Quang Dũng",
                            Bio = "Nguyễn Quang Dũng",
                            ProfilePictureURL = "https://photo-cms-tpo.epicdn.me/Uploaded/2023/anijt/2019_05_13/3tieu_su_nghe_si_quang_dung_1_phunutodayvn_0913_WZON.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Charlie Nguyễn",
                            Bio = "Charlie Nguyễn",
                            ProfilePictureURL = "https://vcdn1-giaitri.vnecdn.net/2018/11/04/settopcharlienguyenhocdienanht-7556-9128-1541317801.jpg?w=1200&h=0&q=100&dpr=1&fit=crop&s=xylHdVUI3tow3pf5aRClCw"
                        },
                        new Producer()
                        {
                            FullName = "Phan Đăng Di",
                            Bio = "Phan Đăng Di",
                            ProfilePictureURL = "https://media.viez.vn/prod/2023/5/6/phan_dang_di_7333_1558051964_1_065a2c5af2.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Mắt Biếc",
                            Description = "Mắt Biếc sẽ chính thức khởi chiếu tại các rạp trên toàn quốc vào 20.12.2019",
                            Price = 65,
                            ImageURL = "https://i.ytimg.com/vi/ITlQ0oU7tDA/maxresdefault.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Em Chưa 18",
                            Description = "Em Chưa 18",
                            Price = 70,
                            ImageURL = "https://static.vieon.vn/vieplay-image/thumbnail_v4/2021/01/05/wtk9qmeg_1_horizontal-thumbnail3dec0e4f2ca474c374961c3bd8638571.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Em Là Bà Nội Của Anh",
                            Description = "Em Là Bà Nội Của Anh",
                            Price = 60,
                            ImageURL = "https://cdn-i.vtcnews.vn/files/f1/2016/02/22/20151208105342em_lajpg.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Lật Mặt 6",
                            Description = "Tấm vé có mệnh giá 10.000 đồng và sở hữu những con số định mệnh: 10, 16, 18, 20, 27, 28 - ngày sinh của hội bạn thân sáu người",
                            Price = 65,
                            ImageURL = "https://i.ytimg.com/vi/2EnP2tVC00Q/maxresdefault.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Gái Già Lắm Chiêu V",
                            Description = "Gái già lắm chiêu V",
                            Price = 39.50,
                            ImageURL = "https://rapchieuphim.com/photos/5298/gglc.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Tháng Năm Rực Rỡ",
                            Description = "Tháng năm rực rỡ",
                            Price = 39.50,
                            ImageURL = "https://znews-photo.zingcdn.me/w660/Uploaded/xbhunku/2018_03_08/tnrr.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
