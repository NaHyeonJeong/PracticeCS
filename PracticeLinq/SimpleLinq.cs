using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class SimpleLinq
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile() { Name = "나현정", Height = 154 },
                new Profile() { Name = "나현진", Height = 160 },
                new Profile() { Name = "김철수", Height = 170 },
                new Profile() { Name = "최영희", Height = 140 },
                new Profile() { Name = "알파고", Height = 169 },
                new Profile() { Name = "테스트", Height = 159 }
            };

            var profiles = arrProfile
                                .Where(profile => profile.Height < 170)
                                .OrderBy(profile => profile.Height)
                                .Select(profile => new
                                {
                                    Name = profile.Name,
                                    InchHeight = profile.Height * 0.393
                                });

            foreach(var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}
