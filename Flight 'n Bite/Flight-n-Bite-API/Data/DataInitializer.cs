using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        private readonly IOrderLineRepository _orderLineRepository;
        private readonly IPassengerRepository _passengerRepository;
        private readonly IPersonnelRepository _personnelRepository;
        private readonly IGroupRepository _groupRepository;
        private readonly UserManager<IdentityUser> _userManager;


        public DataInitializer(FlightDbContext context,
            IFlightRepository flightRepository,
            IMovieRepository movieRepository,
            IMusicRepository musicRepository,
            IArtistRepository artistRepository,
            IProductRepository productRepository,
            IOrderRepository orderRepository,
            IOrderLineRepository orderLineRepository,
            IPassengerRepository passengerRepository,
            IPersonnelRepository personnelRepository,
            IGroupRepository groupRepository,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _flightRepository = flightRepository;
            _movieRepository = movieRepository;
            _musicRepository = musicRepository;
            _artistRepository = artistRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderLineRepository = orderLineRepository;
            _passengerRepository = passengerRepository;
            _personnelRepository = personnelRepository;
            _groupRepository = groupRepository;
            _userManager = userManager;

        }

        public async Task InitializeData()
        {
            _context.Database.EnsureDeleted();
            if (_context.Database.EnsureCreated())
            {
     
                var flight = new Flight() { Number = "X44795", Departure = "Brussel", Arrival = "Madrid"};
                for (int i = 1; i < 30; i++)
                {
                    flight.AddSeat(new Seat() { Number = $"X{i}" });
                }

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
                var lmd = new Artist() { Name = "Lewis MacDougall" };
                _artistRepository.Add(lmd);
                var sw = new Artist() { Name = "Sigourney Weaver" };
                _artistRepository.Add(sw);
                var fj = new Artist() { Name = "Felicity Jones" };
                _artistRepository.Add(fj);
                var tk = new Artist() { Name = "Toby Kebbell" };
                _artistRepository.Add(tk);
                var sc = new Artist() { Name = "Sharlto Copley" };
                _artistRepository.Add(sc);
                var dp = new Artist() { Name = "Dev Patel" };
                _artistRepository.Add(dp);
                var ninja = new Artist() { Name = "Ninja" };
                _artistRepository.Add(ninja);
                var ylv = new Artist() { Name = "Yo-Mandi Visser" };
                _artistRepository.Add(ylv);
                var bc = new Artist() { Name = "Benedict Cumberbatch" };
                _artistRepository.Add(bc);
                var ce = new Artist() { Name = "Chiwetel Ejiofor" };
                _artistRepository.Add(ce);
                var rca = new Artist() { Name = "Rachel McAdams" };
                _artistRepository.Add(rca);
                var bew = new Artist() { Name = "Benedict Wong" };
                _artistRepository.Add(bew);
                var tc = new Artist() { Name = "Tom Cruise" };
                _artistRepository.Add(tc);
                var eb = new Artist() { Name = "Emily Blunt" };
                _artistRepository.Add(eb);
                var bg = new Artist() { Name = "Brendan Gleeson" };
                _artistRepository.Add(bg);
                var bp = new Artist() { Name = "Bill Paxton" };
                _artistRepository.Add(bp);
                var rdj = new Artist() { Name = "Robert Downey Jr." };
                _artistRepository.Add(rdj);
                var ch = new Artist() { Name = "Chris Hemsworth" };
                _artistRepository.Add(ch);
                var che = new Artist() { Name = "Chris Evans" };
                _artistRepository.Add(che);
                var mr = new Artist() { Name = "Mark Ruffalo" };
                _artistRepository.Add(mr);
                var dg = new Artist() { Name = "Domhnall Gleeson" };
                _artistRepository.Add(dg);
                var av = new Artist() { Name = "Alicia Vikander" };
                _artistRepository.Add(av);
                var oi = new Artist() { Name = "Oscar Isaac" };
                _artistRepository.Add(oi);
                var sm = new Artist() { Name = "Sonoya Mizuno" };
                _artistRepository.Add(sm);
                var th = new Artist() { Name = "Tom Holland" };
                _artistRepository.Add(th);
                var jg = new Artist() { Name = "Jake Gyllenhaal" };
                _artistRepository.Add(jg);
                var mt = new Artist() { Name = "Marisa Tomei" };
                _artistRepository.Add(mt);
                var sj = new Artist() { Name = "Scarlet Johansson" };
                _artistRepository.Add(sj);
                var pa = new Artist() { Name = "Pilou Asbæk" };
                _artistRepository.Add(pa);
                var tak = new Artist() { Name = "Takeshi Kitano" };
                _artistRepository.Add(tak);
                var jb = new Artist() { Name = "Juliette Binoche" };
                _artistRepository.Add(jb);
                var mk = new Artist() { Name = "Michael Keaton" };
                _artistRepository.Add(mk);
                var teh = new Artist() { Name = "Terrence Howard" };
                _artistRepository.Add(teh);
                var jeb = new Artist() { Name = "Jeff Bridges" };
                _artistRepository.Add(jeb);
                var gp = new Artist() { Name = "Gwyneth Paltrow" };
                _artistRepository.Add(gp);
                var dc = new Artist() { Name = "Don Cheadle" };
                _artistRepository.Add(dc);
                var gup = new Artist() { Name = "Guy Pearce" };
                _artistRepository.Add(gup);
                var hj = new Artist() { Name = "Hugh Jackman" };
                _artistRepository.Add(hj);
                var ps = new Artist() { Name = "Patrick Stewart" };
                _artistRepository.Add(ps);
                var dk = new Artist() { Name = "Dafne Keen" };
                _artistRepository.Add(dk);
                var bh = new Artist() { Name = "Boyd Holbrook" };
                _artistRepository.Add(bh);
                var mf = new Artist() { Name = "Morgan Freeman" };
                _artistRepository.Add(mf);
                var ok = new Artist() { Name = "Olga Kurylenko" };
                _artistRepository.Add(ok);
                var ar = new Artist() { Name = "Andrea Riseborough" };
                _artistRepository.Add(ar);
                var jl = new Artist() { Name = "Jacob Latimore" };
                _artistRepository.Add(jl);
                var sg = new Artist() { Name = "Seychelle Gabriel" };
                _artistRepository.Add(sg);
                var sr = new Artist() { Name = "Storm Reid" };
                _artistRepository.Add(sr);
                var da = new Artist() { Name = "Donzaleigh Abernathy" };
                _artistRepository.Add(ar);
                var kk = new Artist() { Name = "Keira Knightley" };
                _artistRepository.Add(kk);
                var mg = new Artist() { Name = "Matthew Goode" };
                _artistRepository.Add(ar);
                var rk = new Artist() { Name = "Rory Kinnear" };
                _artistRepository.Add(ar);
                var brp = new Artist() { Name = "Brad Pitt" };
                _artistRepository.Add(brp);
                var me = new Artist() { Name = "Mireille Enos" };
                _artistRepository.Add(me);
                var dak = new Artist() { Name = "Daniella Kertesz" };
                _artistRepository.Add(dak);
                var jbd = new Artist() { Name = "James Badge Dale" };
                _artistRepository.Add(jbd);
                _artistRepository.SaveChanges();

                //Movie
                var joker = new Movie()
                {
                    Title = "JOKER",
                    Description = "In Gotham City, mentally-troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: \"The Joker\".",
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
                    Description = "Security guard David Dunn uses his supernatural abilities to track Kevin Wendell Crumb, a disturbed man who has twenty-four personalities.",
                    Director = "M. Night Shyamalan",
                    Rating = 6.7,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTY1OTA2MjI5OV5BMl5BanBnXkFtZTgwNzkxMjU4NjM@._V1_SX300.jpg"
                };
                glass.AddActor(jma);
                glass.AddActor(bw);
                glass.AddActor(slj);
                glass.AddActor(atj);
                _movieRepository.Add(glass);

                var aMonsterCalls = new Movie()
                {
                    Title = "A Monster Calls",
                    Description = "A boy seeks the help of a tree monster to cope with his single mother's terminal illness.",
                    Director = "J.A. Bayona",
                    Rating = 7.5,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTg1OTA5OTkyNV5BMl5BanBnXkFtZTgwODMwNDU5OTE@._V1_SX300.jpg"
                };
                aMonsterCalls.AddActor(lmd);
                aMonsterCalls.AddActor(sw);
                aMonsterCalls.AddActor(fj);
                aMonsterCalls.AddActor(tk);
                _movieRepository.Add(aMonsterCalls);

                var chappie = new Movie()
                {
                    Title = "CHAPPIE",
                    Description = "In the near future, crime is patrolled by a mechanized police force. When one police droid, Chappie, is stolen and given new programming, he becomes the first robot with the ability to think and feel for himself.",
                    Director = "Neill Blomkamp",
                    Rating = 6.8,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTUyNTI4NTIwNl5BMl5BanBnXkFtZTgwMjQ4MTI0NDE@._V1_SX300.jpg"
                };
                chappie.AddActor(sc);
                chappie.AddActor(dp);
                chappie.AddActor(ninja);
                chappie.AddActor(ylv);
                _movieRepository.Add(chappie);

                var doctorStrange = new Movie()
                {
                    Title = "Doctor Strange",
                    Description = "While on a journey of physical and spiritual healing, a brilliant neurosurgeon is drawn into the world of the mystic arts.",
                    Director = "Scott Derrickson",
                    Rating = 7.5,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BNjgwNzAzNjk1Nl5BMl5BanBnXkFtZTgwMzQ2NjI1OTE@._V1_SX300.jpg"
                };
                doctorStrange.AddActor(bc);
                doctorStrange.AddActor(ce);
                doctorStrange.AddActor(rca);
                doctorStrange.AddActor(bew);
                _movieRepository.Add(doctorStrange);

                var edgeOfTomorrow = new Movie()
                {
                    Title = "Edge of Tomorrow",
                    Description = "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies.",
                    Director = "Doug Liman",
                    Rating = 7.9,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTc5OTk4MTM3M15BMl5BanBnXkFtZTgwODcxNjg3MDE@._V1_SX300.jpg"
                };
                edgeOfTomorrow.AddActor(tc);
                edgeOfTomorrow.AddActor(eb);
                edgeOfTomorrow.AddActor(bg);
                edgeOfTomorrow.AddActor(bp);
                _movieRepository.Add(edgeOfTomorrow);

                var endgame = new Movie()
                {
                    Title = "Endgame",
                    Description = "After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to reverse Thanos' actions and restore balance to the universe.",
                    Director = "Anthony Russo, Joe Russo",
                    Rating = 8.5,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTc5MDE2ODcwNV5BMl5BanBnXkFtZTgwMzI2NzQ2NzM@._V1_SX300.jpg"
                };
                endgame.AddActor(rdj);
                endgame.AddActor(ch);
                endgame.AddActor(che);
                endgame.AddActor(mr);
                _movieRepository.Add(endgame);

                var infinityWar = new Movie()
                {
                    Title = "Infinity War",
                    Description = "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.",
                    Director = "Anthony Russo, Joe Russo",
                    Rating = 8.5,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMjMxNjY2MDU1OV5BMl5BanBnXkFtZTgwNzY1MTUwNTM@._V1_SX300.jpg"
                };
                endgame.AddActor(rdj);
                endgame.AddActor(ch);
                endgame.AddActor(che);
                endgame.AddActor(mr);
                _movieRepository.Add(infinityWar);

                var exMachina = new Movie()
                {
                    Title = "Ex Machina",
                    Description = "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a highly advanced humanoid A.I.",
                    Director = "Alex Garland",
                    Rating = 7.7,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg"
                };
                exMachina.AddActor(dg);
                exMachina.AddActor(av);
                exMachina.AddActor(oi);
                exMachina.AddActor(sm);
                _movieRepository.Add(exMachina);

                var farFromHome = new Movie()
                {
                    Title = "Far from Home",
                    Description = "Following the events of Avengers: Endgame, Spider-Man must step up to take on new threats in a world that has changed forever.",
                    Director = "Jon Watts",
                    Rating = 7.6,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SX300.jpg"
                };
                farFromHome.AddActor(slj);
                farFromHome.AddActor(th);
                farFromHome.AddActor(jg);
                farFromHome.AddActor(mt);
                _movieRepository.Add(farFromHome);

                var ghostInTheShell = new Movie()
                {
                    Title = "Ghost in the Shell",
                    Description = "In the near future, Major Mira Killian is the first of her kind: A human saved from a terrible crash, who is cyber-enhanced to be a perfect soldier devoted to stopping the world's most dangerous criminals.",
                    Director = "Rupert Sanders",
                    Rating = 6.3,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMzJiNTI3MjItMGJiMy00YzA1LTg2MTItZmE1ZmRhOWQ0NGY1XkEyXkFqcGdeQXVyOTk4MTM0NQ@@._V1_SX300.jpg"
                };
                ghostInTheShell.AddActor(sj);
                ghostInTheShell.AddActor(pa);
                ghostInTheShell.AddActor(tak);
                ghostInTheShell.AddActor(jb);
                _movieRepository.Add(ghostInTheShell);

                var homecoming = new Movie()
                {
                    Title = "Homecoming",
                    Description = "Peter Parker balances his life as an ordinary high school student in Queens with his superhero alter-ego Spider-Man, and finds himself on the trail of a new menace prowling the skies of New York City.",
                    Director = "Jon Watts",
                    Rating = 7.4,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_SX300.jpg"
                };
                homecoming.AddActor(rdj);
                homecoming.AddActor(th);
                homecoming.AddActor(mt);
                homecoming.AddActor(mk);
                _movieRepository.Add(homecoming);

                var ironMan = new Movie()
                {
                    Title = "Iron Man",
                    Description = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
                    Director = "Jon Favreau",
                    Rating = 7.9,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTczNTI2ODUwOF5BMl5BanBnXkFtZTcwMTU0NTIzMw@@._V1_SX300.jpg"
                };
                ironMan.AddActor(rdj);
                ironMan.AddActor(th);
                ironMan.AddActor(jeb);
                ironMan.AddActor(gp);
                _movieRepository.Add(ironMan);

                var ironMan2 = new Movie()
                {
                    Title = "Iron Man 2",
                    Description = "With the world now aware of his identity as Iron Man, Tony Stark must contend with both his declining health and a vengeful mad man with ties to his father's legacy.",
                    Director = "Jon Favreau",
                    Rating = 7.0,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTM0MDgwNjMyMl5BMl5BanBnXkFtZTcwNTg3NzAzMw@@._V1_SX300.jpg"
                };
                ironMan2.AddActor(rdj);
                ironMan2.AddActor(gp);
                ironMan2.AddActor(sj);
                ironMan2.AddActor(dc);
                _movieRepository.Add(ironMan2);

                var ironMan3 = new Movie()
                {
                    Title = "Iron Man 3",
                    Description = "When Tony Stark's world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.",
                    Director = "Shane Black",
                    Rating = 7.2,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMjE5MzcyNjk1M15BMl5BanBnXkFtZTcwMjQ4MjcxOQ@@._V1_SX300.jpg"
                };
                ironMan2.AddActor(rdj);
                ironMan2.AddActor(gp);
                ironMan2.AddActor(sj);
                ironMan2.AddActor(gup);
                _movieRepository.Add(ironMan3);

                var logan = new Movie()
                {
                    Title = "Logan",
                    Description = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.",
                    Director = "James Mangold",
                    Rating = 7.2,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BYzc5MTU4N2EtYTkyMi00NjdhLTg3NWEtMTY4OTEyMzJhZTAzXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_SX300.jpg"
                };
                logan.AddActor(hj);
                logan.AddActor(ps);
                logan.AddActor(dk);
                logan.AddActor(bh);
                _movieRepository.Add(logan);

                var oblivion = new Movie()
                {
                    Title = "Oblivion",
                    Description = "A veteran assigned to extract Earth's remaining resources begins to question what he knows about his mission and himself.",
                    Director = "Joseph Kosinski",
                    Rating = 7.0,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BMTQwMDY0MTA4MF5BMl5BanBnXkFtZTcwNzI3MDgxOQ@@._V1_SX300.jpg"
                };
                oblivion.AddActor(tc);
                oblivion.AddActor(mf);
                oblivion.AddActor(ok);
                oblivion.AddActor(ar);
                _movieRepository.Add(oblivion);

                var sleight = new Movie()
                {
                    Title = "Oblivion",
                    Description = "A young street magician (Jacob Latimore) is left to care for his little sister after their parents' passing, and turns to illegal activities to keep a roof over their heads. When he gets in...",
                    Director = "J.D. Dillard",
                    Rating = 5.9,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BODRjMDRlMmUtNGFiZi00NjIwLWJkMDgtZGU5NjY4MDNmODg3XkEyXkFqcGdeQXVyMjU3NTI0Mg@@._V1_SX300.jpg"
                };
                sleight.AddActor(jl);
                sleight.AddActor(sg);
                sleight.AddActor(sr);
                sleight.AddActor(da);
                _movieRepository.Add(sleight);

                var theImmitationGame = new Movie()
                {
                    Title = "The Imitation Game",
                    Description = "During World War II, the English mathematical genius Alan Turing tries to crack the German Enigma code with help from fellow mathematicians.",
                    Director = "Morten Tyldum",
                    Rating = 8.0,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BOTgwMzFiMWYtZDhlNS00ODNkLWJiODAtZDVhNzgyNzJhYjQ4L2ltYWdlXkEyXkFqcGdeQXVyNzEzOTYxNTQ@._V1_SX300.jpg"
                };
                theImmitationGame.AddActor(bc);
                theImmitationGame.AddActor(kk);
                theImmitationGame.AddActor(mg);
                theImmitationGame.AddActor(rk);
                _movieRepository.Add(theImmitationGame);

                var worldWarZ = new Movie()
                {
                    Title = "Wolrd War Z",
                    Description = "Former United Nations employee Gerry Lane traverses the world in a race against time to stop the Zombie pandemic that is toppling armies and governments, and threatening to destroy humanity itself.",
                    Director = "Marc Forster",
                    Rating = 7.0,
                    PosterUri = "https://m.media-amazon.com/images/M/MV5BNDQ4YzFmNzktMmM5ZC00MDZjLTk1OTktNDE2ODE4YjM2MjJjXkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg"
                };
                worldWarZ.AddActor(brp);
                worldWarZ.AddActor(me);
                worldWarZ.AddActor(dak);
                worldWarZ.AddActor(jbd);
                _movieRepository.Add(worldWarZ);
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
                var erase = new Music() { Title = "Erase", Artist = cc, Album = "Erase", CoverUri = "https://sslg.ulximg.com/image/750x750/cover/1568586321_067906add91fa367db821dffda4503dd.jpg/99a0153f773c57ce55b32fb2215d1fd4/1568586321_972607c6e3946d12757661231e751d94.jpg" };
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

            var k = new Passenger() { FirstName = "k", LastName = "k", SeatIdentifier = "X25" };
 
            var jef = new Passenger() { FirstName = "Jef", LastName = "Malfliet", SeatIdentifier = "X2" };
            var nante = new Passenger() { FirstName = "Nante", LastName = "Vermeulen", SeatIdentifier = "X3" };
            var mout = new Passenger() { FirstName = "Mout", LastName = "Pessemier", SeatIdentifier = "X4" };
            Group coolios = new Group();
            coolios.JoinGroup(jef);
            coolios.JoinGroup(nante);
            coolios.JoinGroup(mout);

            var indy = new Passenger() { FirstName = "Indy", LastName = "Van Cangem", SeatIdentifier = "X5" };
            var bram = new Passenger() { FirstName = "Bram", LastName = "Van Overbeke", SeatIdentifier = "X6" };
            var robbe = new Passenger() { FirstName = "Robbe", LastName = "Van De Vyver", SeatIdentifier = "X7" };
            Group stinkios = new Group();
            stinkios.JoinGroup(indy);
            stinkios.JoinGroup(bram);
            stinkios.JoinGroup(robbe);

            coolios.Chat.Add(new Message() { body = "Jow, pekes! Kheb er zin in!", Passenger = jef });
            coolios.Chat.Add(new Message() { body = "Ja swa zeker wel", Passenger = mout });
            coolios.Chat.Add(new Message() { body = "absoluut 😋", Passenger = nante });
            coolios.Chat.Add(new Message() { body = "Ik ga naar die nice films zien tijdens de vlucht, gelle?", Passenger = mout });
            coolios.Chat.Add(new Message() { body = "Zwaar wa muziek knalle", Passenger = jef });
            coolios.Chat.Add(new Message() { body = "Ja kga ook naar ne film zien of wa slapen", Passenger = nante });



            _passengerRepository.Add(k);
            _passengerRepository.Add(jef);
            _passengerRepository.Add(nante);
            _passengerRepository.Add(mout);
            _passengerRepository.Add(indy);
            _passengerRepository.Add(bram);
            _passengerRepository.Add(robbe);
            _passengerRepository.SaveChanges();

            _groupRepository.AddGroup(coolios);
            _groupRepository.AddGroup(stinkios);
            _groupRepository.SaveChanges();

            var personel = new Personnel { UserName = "Piloot@hotmail.com" };
            var personel2 = new Personnel { UserName = "Stewardess@hotmail.com"};
            await CreateUser(personel.UserName, "Piloot123!");
            await CreateUser(personel2.UserName, "Stewardess123!");

            _personnelRepository.Add(personel);
            _personnelRepository.Add(personel2);
            _personnelRepository.SaveChanges();


            var fristi = new Product() { Name = "Fristi", Description = "Dat lekkere drankje, alleen voor grotere jongens", Price = 5.0 };
            var soldatenkoek = new Product() { Name = "soldatenkoek", Description = "Een lekkere gewone koek voor brave mannekes", Price = 2.0 };
            var borrelnootjes = new Product() { Name = "borrelnootjes", Description = "Perfect voor bij een sterke trappist", Price = 3.0 };
            var trappist = new Product() { Name = "Trappist", Description = "Perfect voor bij lekker borrelnootjes", Price = 7.5 };

            var orderline1 = new OrderLine() { Product = fristi, Amount = 5 };
            var orderline2 = new OrderLine() { Product = soldatenkoek, Amount = 2 };
            var orderline3 = new OrderLine() { Product = borrelnootjes, Amount = 1 };
            var orderline4 = new OrderLine() { Product = trappist, Amount = 2 };
            var orderline5 = new OrderLine() { Product = fristi, Amount = 1 };
            var orderline6 = new OrderLine() { Product = fristi, Amount = 1 };

            var order1 = new Order() { Passenger = jef, OrderLines = new List<OrderLine>() { orderline1, orderline2} };
            var order2 = new Order() { Passenger = nante, OrderLines = new List<OrderLine>() { orderline3, orderline4 } };
            var order3 = new Order() { Passenger = mout, OrderLines = new List<OrderLine>() { orderline5 } };
            var order4 = new Order() { Passenger = mout, OrderLines = new List<OrderLine>() { orderline6 } };

            _productRepository.Add(fristi);
            _productRepository.Add(soldatenkoek);
            _productRepository.Add(borrelnootjes);
            _productRepository.Add(trappist);
            _productRepository.SaveChanges();

            _orderLineRepository.Add(orderline1);
            _orderLineRepository.Add(orderline2);
            _orderLineRepository.Add(orderline3);
            _orderLineRepository.Add(orderline4);
            _orderLineRepository.Add(orderline5);
            _orderLineRepository.Add(orderline6);
            _orderLineRepository.SaveChanges();

            _orderRepository.Add(order1);
            _orderRepository.Add(order2);
            _orderRepository.Add(order3);
            _orderRepository.Add(order4);
            _orderRepository.SaveChanges();

        }

        private async Task CreateUser(string username, string password)
        {
            var user = new IdentityUser {UserName = username,Email= username};
            await _userManager.CreateAsync(user, password);
        }
    }
}
