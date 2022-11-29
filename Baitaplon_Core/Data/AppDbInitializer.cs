using Baitaplon_Core.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuiler)
        {
            using(var servicesScope = applicationBuiler.ApplicationServices.CreateScope())
            {
                var context = servicesScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Ten = "Rạp 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            ChiTiet = "Giới thiệu về rạp phim 1"
                        },
                        new Cinema()
                        {
                            Ten = "Rạp 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            ChiTiet = "Giới thiệu về rạp phim 2"
                        },
                        new Cinema()
                        {
                            Ten = "Rạp 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            ChiTiet = "Giới thiệu về rạp phim 3"
                        },
                        new Cinema()
                        {
                            Ten = "Rạp 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            ChiTiet = "Giới thiệu về rạp phim 4"
                        },
                        new Cinema()
                        {
                            Ten = "Rạp 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            ChiTiet = "Giới thiệu về rạp phim 5"
                        },
                    });
                    context.SaveChanges();
                }
                //Actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            HoTen = "Diễn viên 1",
                            TieuSu = "Tiểu sử của diễn viên",
                            Anh = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            HoTen = "Diễn viên 2",
                            TieuSu = "Tiểu sử của diễn viên",
                            Anh = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            HoTen = "Diễn viên 3",
                            TieuSu = "Tiểu sử của diễn viên",
                            Anh = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            HoTen = "Diễn viên 4",
                            TieuSu = "Tiểu sử của diễn viên",
                            Anh = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            HoTen = "Diễn viên 5", 
                            TieuSu = "Tiểu sử của diễn viên", 
                            Anh = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producer
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            HoTen = "Nhà sản xuất 1",
                            TieuSu = "Tiểu sử nhà sản xuất",
                            Anh = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            HoTen = "Nhà sản xuất 2",
                            TieuSu = "Tiểu sử nhà sản xuất",
                            Anh = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {HoTen = "Nhà sản xuất 3", TieuSu = "Tiểu sử nhà sản xuất", Anh = "http://dotnethow.net/images/producers/producer-3.jpeg"},
                        new Producer()
                        {HoTen = "Nhà sản xuất 4", TieuSu = "Tiểu sử nhà sản xuất", Anh = "http://dotnethow.net/images/producers/producer-4.jpeg"},
                        new Producer()
                        {HoTen = "Nhà sản xuất 5", TieuSu = "Tiểu sử nhà sản xuất", Anh = "http://dotnethow.net/images/producers/producer-5.jpeg"}
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movies>()
                    {
                        new Movies()
                        {
                            Ten = "Life",
                            Chitiet = "Chi tiết phim",
                            Gia = 39.50,
                            Anh = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            NgayBatDau = DateTime.Now.AddDays(-10),
                            NgayKetThuc = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            DanhMuc = DanhMuc.Documentary
                        },
                        new Movies()
                        {
                            Ten = "The Shawshank Redemption",
                            Chitiet = "Chi tiết phim",
                            Gia = 29.50,
                            Anh = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            NgayBatDau = DateTime.Now,
                            NgayKetThuc = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            DanhMuc = DanhMuc.Action
                        },
                        new Movies()
                        {
                            Ten = "Ghost",
                            Chitiet = "Chi tiết phim",
                            Gia = 39.50,
                            Anh = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            NgayBatDau = DateTime.Now,
                            NgayKetThuc = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            DanhMuc = DanhMuc.Horror
                        },
                        new Movies()
                        {
                            Ten = "Race",
                            Chitiet = "Chi tiết phim",
                            Gia = 39.50,
                            Anh = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            NgayBatDau = DateTime.Now.AddDays(-10),
                            NgayKetThuc = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            DanhMuc = DanhMuc.Documentary
                        },
                        new Movies()
                        {
                            Ten = "Scoob",
                            Chitiet = "Chi tiết phim",
                            Gia = 39.50,
                            Anh = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            NgayBatDau = DateTime.Now.AddDays(-10),
                            NgayKetThuc = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            DanhMuc = DanhMuc.Cartoon
                        },
                        new Movies()
                        {
                            Ten = "Cold Soles",
                            Chitiet = "Chi tiết phim",
                            Gia = 39.50,
                            Anh = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            NgayBatDau = DateTime.Now.AddDays(3),
                            NgayKetThuc = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            DanhMuc = DanhMuc.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actor & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MoviesId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MoviesId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MoviesId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MoviesId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MoviesId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MoviesId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MoviesId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MoviesId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MoviesId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MoviesId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MoviesId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MoviesId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MoviesId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MoviesId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MoviesId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MoviesId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MoviesId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
