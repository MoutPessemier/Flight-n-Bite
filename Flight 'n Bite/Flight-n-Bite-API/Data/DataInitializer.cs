using Flight_n_Bite_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_n_Bite_API.Data
{
    public class DataInitializer
    {
        private readonly FlightDbContext _context;
        private readonly IFlightRepository _flightRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IMusicRepository _musicRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public DataInitializer(FlightDbContext context,
            IFlightRepository flightRepository,
            IMovieRepository movieRepository,
            IMusicRepository musicRepository,
            IArtistRepository artistRepository,
            IProductRepository productRepository,
            IOrderRepository orderRepository)
        {
            _context = context;
            _flightRepository = flightRepository;
            _movieRepository = movieRepository;
            _musicRepository = musicRepository;
            _artistRepository = artistRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        public void InitializeData()
        {
            _context.Database.EnsureDeleted();
            if (_context.Database.EnsureCreated())
            {
                var flight = new Flight() { Number = "X44795", Departure = "Brussel", Arrival = "Madrid" };
                _flightRepository.Add(flight);
                _flightRepository.SaveChanges();

                //Artists
                var ak = new Artist() { Name = "AK" };
                _artistRepository.Add(ak);
                var banners = new Artist() { Name = "BANNERS" };
                _artistRepository.Add(banners);
                var bi = new Artist() { Name = "Bon Iver" };
                _artistRepository.Add(bi);
                var cc = new Artist() { Name = "Cautious Clay" };
                _artistRepository.Add(cc);
                var ed = new Artist() { Name = "Ed Sheeran" };
                _artistRepository.Add(ed);
                var fw = new Artist() { Name = "Fettu Wap" };
                _artistRepository.Add(fw);
                var haywyre = new Artist() { Name = "haywyre" };
                _artistRepository.Add(haywyre);
                var kw = new Artist() { Name = "Kanye West" };
                _artistRepository.Add(kw);
                var kina = new Artist() { Name = "kina" };
                _artistRepository.Add(kina);
                var lol = new Artist() { Name = "League of Legends" };
                _artistRepository.Add(lol);
                var midoca = new Artist() { Name = "Midoca" };
                _artistRepository.Add(midoca);
                var modl = new Artist() { Name = "Módl" };
                _artistRepository.Add(modl);
                var nf = new Artist() { Name = "NF" };
                _artistRepository.Add(nf);
                var orbicus = new Artist() { Name = "Orbicus" };
                _artistRepository.Add(orbicus);
                var pdp = new Artist() { Name = "PewDiePie" };
                _artistRepository.Add(pdp);
                var pm = new Artist() { Name = "Post Malone" };
                _artistRepository.Add(pm);
                var tr = new Artist() { Name = "Terror Reid" };
                _artistRepository.Add(tr);
                var cr = new Artist() { Name = "Cailin Russo" };
                _artistRepository.Add(cr);
                var chc = new Artist() { Name = "Chrissy Costanza" };
                _artistRepository.Add(chc);
                var ruelle = new Artist() { Name = "Ruelle" };
                _artistRepository.Add(ruelle);
                var fleurie = new Artist() { Name = "Fleurie" };
                _artistRepository.Add(fleurie);
                var ss = new Artist() { Name = "Sasha Sloan" };
                _artistRepository.Add(ss);
                var pib = new Artist() { Name = "Party In Backyard" };
                _artistRepository.Add(pib);

                //Actors
                var jp = new Artist() { Name = "Joaquin Phoenix" };
                _artistRepository.Add(jp);
                var rdn = new Artist() { Name = "Robert De Niro" };
                _artistRepository.Add(rdn);
                var zb = new Artist() { Name = "Zazie Beetz" };
                _artistRepository.Add(zb);
                var fc = new Artist() { Name = "Frances Conroy" };
                _artistRepository.Add(fc);
                var jma = new Artist() { Name = "James McAvoy" };
                _artistRepository.Add(jma);
                var bw = new Artist() { Name = "Bruce Willis" };
                _artistRepository.Add(bw);
                var slj = new Artist() { Name = "Samuel L. Jackson" };
                _artistRepository.Add(slj);
                var atj = new Artist() { Name = "Anya Taylor-Joy" };
                _artistRepository.Add(atj);

                _artistRepository.SaveChanges();

                //Movie
                var joker = new Movie()
                {
                    Title = "JOKER",
                    Description = "In Gotham City, mentally-troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: \"The Joker\"",
                    Director = "Todd Phillips",
                    Rating = 8.9,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BNGVjNWI4ZGUtNzE0MS00YTJmLWE0ZDctN2ZiYTk2YmI3NTYyXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg"
                };
                joker.AddActor(jp);
                joker.AddActor(rdn);
                joker.AddActor(zb);
                joker.AddActor(fc);
                _movieRepository.Add(joker);

                var glass = new Movie()
                {
                    Title = "Glass",
                    Description = "Security guard David Dunn uses his supernatural abilities to track Kevin Wendell Crumb, a disturbed man who has twenty-four personalities",
                    Director = "M. Night Shyamalan",
                    Rating = 6.7,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTY1OTA2MjI5OV5BMl5BanBnXkFtZTgwNzkxMjU4NjM@._V1_SX300.jpg"
                };
                glass.AddActor(jma);
                glass.AddActor(bw);
                glass.AddActor(slj);
                glass.AddActor(atj);
                _movieRepository.Add(glass);

                _movieRepository.SaveChanges();

                //Music
                var broken = new Music() { Title = "Broken", Artist = ak, Album = "Broken", CoverUri = "https://cdn2.albumoftheyear.org/345x/album/163186-broken.jpg" };
                _musicRepository.Add(broken);
                var halfLight = new Music() { Title = "Half Light", Artist = banners, Album = "The Royals SoundTrack", CoverUri = "https://c.saavncdn.com/994/Half-Light-English-2016-500x500.jpg" };
                _musicRepository.Add(halfLight);
                var startARiot = new Music() { Title = "Start A Riot", Artist = banners, Album = "Banners", CoverUri = "https://is2-ssl.mzstatic.com/image/thumb/Music118/v4/1d/64/d3/1d64d37d-5c3c-8d63-50c6-8a0b75b0d5fc/source/1200x1200bb.jpg" };
                _musicRepository.Add(startARiot);
                var holocene = new Music() { Title = "Holocene", Artist = bi, Album = "Bon Iver", CoverUri = "https://upload.wikimedia.org/wikipedia/en/5/5f/Bon_iver.jpg" };
                _musicRepository.Add(holocene);
                var erase = new Music() { Title = "Erase", Artist = cc, Album = "Erase", CoverUri= "https://sslg.ulximg.com/image/750x750/cover/1568586321_067906add91fa367db821dffda4503dd.jpg/99a0153f773c57ce55b32fb2215d1fd4/1568586321_972607c6e3946d12757661231e751d94.jpg" };
                _musicRepository.Add(erase);
                var iSeeFire = new Music() { Title = "I See Fire", Artist = ed, Album = "The Hobbit: The Desolation of Smaug", CoverUri = "https://i.ytimg.com/vi/2fngvQS_PmQ/maxresdefault.jpg" };
                _musicRepository.Add(iSeeFire);
                var trapQueen = new Music() { Title = "Trap Queen (Crankdat Remix)", Artist = fw, Album = "Fetty Wap", CoverUri = "https://www.mtvpersian.net/covers/thumbs2/18345_18345_400.jpg" };
                _musicRepository.Add(trapQueen);
                var neverCountOnMe = new Music() { Title = "Never Count on Me", Artist = haywyre, Album = "Haywyre", CoverUri = "https://is3-ssl.mzstatic.com/image/thumb/Music123/v4/21/12/58/21125899-b785-4021-5d93-048ae8a0d646/cover.jpg/1200x630wp.png" };
                _musicRepository.Add(neverCountOnMe);
                var heartless = new Music() { Title = "Heartless", Artist = kw, Album = "808s & Heartbreak", CoverUri = "https://images.rapgenius.com/d1a9ea4c12ee6e7a1b15827ade0e28c6.1000x998x1.jpg" };
                _musicRepository.Add(heartless);
                var iFeelEmpty = new Music() { Title = "i feel empty", Artist = kina, Album = "roses", CoverUri = "https://i1.sndcdn.com/avatars-000567588429-psv9vi-t500x500.jpg" };
                _musicRepository.Add(iFeelEmpty);
                var phoenix = new Music() { Title = "Phoenix", Artist = lol, Album = "Worlds 2019", CoverUri = "https://i1.sndcdn.com/avatars-000703750309-ghcj1l-t500x500.jpg" };
                phoenix.AddArtist(cr);
                phoenix.AddArtist(chc);
                _musicRepository.Add(phoenix);
                var dryTheRose = new Music() { Title = "Dry the Rose", Artist = midoca, Album = "Dry the Rose", CoverUri = "https://media.thehypemagazine.com/wp-content/uploads/2019/09/IMG_9025-1-620x350.jpg" };
                _musicRepository.Add(dryTheRose);
                var clementine = new Music() { Title = "Clementine", Artist = modl, Album = "Clementine", CoverUri = "https://static.qobuz.com/images/covers/ga/jf/wjv2yavp8jfga_600.jpg" };
                _musicRepository.Add(clementine);
                var tenFeetDown = new Music() { Title = "10 Feet Down", Artist = nf, Album = "Perception", CoverUri = "https://images.genius.com/02543f01dfa688d0e7de36632a1cd58b.1000x1000x1.jpg" };
                tenFeetDown.AddArtist(ruelle);
                _musicRepository.Add(tenFeetDown);
                var mansion = new Music() { Title = "Mansion", Artist = nf, Album = "Mansion", CoverUri = "https://upload.wikimedia.org/wikipedia/en/4/42/Mansion_by_NF.png" };
                mansion.AddArtist(fleurie);
                _musicRepository.Add(mansion);
                var only = new Music() { Title = "Only", Artist = nf, Album = "The Search", CoverUri = "https://is1-ssl.mzstatic.com/image/thumb/Music113/v4/b0/f6/b4/b0f6b4d2-82ba-7da1-5ace-6e20ab825427/source/1200x1200bb.jpg" };
                only.AddArtist(ss);
                _musicRepository.Add(only);
                var radioDream = new Music() { Title = "Radio Dream", Artist = orbicus, Album = "Radio Dream", CoverUri = "https://m.media-amazon.com/images/I/41wsK17Ex+L._AA256_.jpg" };
                _musicRepository.Add(radioDream);
                var rewindTime = new Music() { Title = "Rewind Time", Artist = pdp, Album = "Year Review", CoverUri = "https://i1.sndcdn.com/artworks-000464167308-dwl8u7-t500x500.jpg" };
                rewindTime.AddArtist(pib);
                _musicRepository.Add(rewindTime);
                var circles = new Music() { Title = "Circles", Artist = pm, Album = "Holywood's Bleeding", CoverUri = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a5/Post_Malone_-_Circles.png/220px-Post_Malone_-_Circles.png" };
                _musicRepository.Add(circles);
                var whenItsAllGone = new Music() { Title = "When It's All Gone!", Artist = tr, Album = "When It's All Gone", CoverUri = "https://i.ytimg.com/vi/jS751prW1eg/maxresdefault.jpg" };
                _musicRepository.Add(whenItsAllGone);

                _musicRepository.SaveChagnes();
            }
        }
    }
}
