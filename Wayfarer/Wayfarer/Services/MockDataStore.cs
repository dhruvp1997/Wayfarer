using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wayfarer.Models;

namespace Wayfarer.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Statue Of Unity", Description="The world’s tallest statue, Statue of Unity is twice the size of the Statue of Liberty and is currently, the most popular tourist attraction in Gujarat. Dedicated to Indian independence activist Sardar Vallabhbhai Patel, the 182 meter tall statue erected in Narmada Valley Kevadiya colony was completed in 2018. Apart from the statue, the area around it has also been developed as a tourist destination where a number of activities and attractions can be enjoyed. The sound and laser show, butterfly garden, cactus garden, Ayurvedic wellness center, eco-friendly and medicinal plant nursery, handicraft stores, valley of flowers, forest with native trees, children’s park with train and mirror maze, safari park and zoo are the major highlights of the place. One can also enjoy zip-lining, white water rafting, cycling, and boating on the lake.", Image = "Statue_of_Unity_Gujarat.jpg"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Rani Ki Vav", Description="A stepwell in Patan, Rani Ki Vav was built by Queen (Rani) of Bhimdeva, Udayamanti. Constructed in the 11th century to preserve ground water, Rani ki Vav today is a UNESCO World Heritage Site. The major highlights of the stepwell are its walls that are decorated with figurative motifs and showcases images of various gods and goddesses from the Hindu pantheon. The central part of each storey contains the primary sculpture. Winter is the best season to visit Rani Ki Vav as you can enjoy the light shows, cultural events and exhibitions during the Rani Ki Vav Festival.", Image = "Rani_Ki_Vav_Gujarat.jpg"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Great Rann Of Kutch", Description="A must-visit on a trip to Gujarat, Great Rann of Kutch is reputed to be one of the world’s largest white salt deserts. Spanning over an area of 7500 sq km, the salt desert is best to be visited during the Rann Utsav, which happens between November and March. A tent city is set up amidst the desert for tourists during the Rann Utsav and cultural festivals are organised. During the festival, one can enjoy camel safaris and can witness traditional handicraft of Gujarat. One can also experience the village life in the nearby rural areas like Hodka and Dhordo.", Image = "Great_Rann_of_Kutch_Gujarat.jpg"},
                new Item { Id = Guid.NewGuid().ToString(), Text = "Gir National Park", Description="Boasting being the only place in India with the largest population of Asiatic lions, Gir National Park in Junagadh, Gujarat is the best destination for wildlife lovers. Along with lions, this national park is home to more than 300 bird species like greathorned owl, crested serpent eagle. It is also inhabite by other members of the cat family like leopards.", Image = "Gir_National_Park_Asiatic_lion.jpg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dwarkadhish Temple", Description="One of the Chardham destinations and Sapata Turis (seven sacred cities), Dwarkadhish Jagat Mandir in Dwarka, Gujarat is an important religious site.  The word ‘Dwarka’ is made of two words – ‘dwara’ meaning road, and ‘ka’ implying eternal significance. Going by the mythological records, Dwarka was the kingdom of Lord Krishna, and he stayed there for quite some time. This five-storey temple stands on 72 pillars, which according to the science of archeo-astronomy, is of immense significance. The sandstone plinth and walls of the temples are embellished with panels depicting dancers, elephants, musicians and celestial beings. A bridge called Sudama Setu at the base of the temple takes one across the Gomti creek towards the beach.", Image = "Dwarkadhish_Temple_Gujarat.jpg" },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Akshardham Temple", Description="Established in 1992 in Gandhinagar, Akshardham Temple is dedicated to Lord Swaminarayan, who belongs to Vaishnav tradition. The temple is considered to be one of the top sites to see in Gujarat because of its history as well as architecture. Set up in an area of over 23 acres, the temple complex serves as a place for education and entertainment.The major highlight of Akshardham Temple is its architecture. It is built of 6000 tons of pink sandstone and no cement or steel has been used in its construction.The main hall of the temple enshrines 7 feet tall idol of Lord Swaminarayan, which is yet another attraction of Akshardham Temple.", Image = "Akshardham_Temple.jpg" }
            };
        }
        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}