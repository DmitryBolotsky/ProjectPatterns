using System;
using System.Collections.Generic;

namespace projectsamozachet
{
    public class Facade
    {
        public Client_list client_List;
        public Insurancesheet_list insurancesheet_list;
        public Post_list post_list;

        public Facade()
        {
            client_List = Client_list.get_instanse();
            insurancesheet_list = Insurancesheet_list.get_instanse();
            post_list = Post_list.get_instanse();
        }
        public void create_client_list(Object[] obj)
        {
            client_List.add_el(new Client(Convert.ToInt32(obj[0]), obj[1].ToString(), obj[2].ToString(), obj[3].ToString(), Convert.ToInt32(obj[4]), Convert.ToInt32(obj[5]), obj[6].ToString()));
        }
        public void create_insurancesheet_list(Object[] obj)
        {
            insurancesheet_list.add_el(new Insurancesheet(Convert.ToInt32(obj[0]), Convert.ToInt32(obj[1]), Convert.ToInt32(obj[2]), Convert.ToInt32(obj[3]), obj[4].ToString()));
        }
        public void update_insurancesheet_list(Object[] obj)
        {
            insurancesheet_list.update_el(new Insurancesheet(Convert.ToInt32(obj[0]), Convert.ToInt32(obj[1]), Convert.ToInt32(obj[2]), Convert.ToInt32(obj[3]), obj[4].ToString()));
        
        }
        public void create_post_list(Object[] obj)
        {
            post_list.add_el(new Post(Convert.ToInt32(obj[0]), obj[1].ToString()));
        }
        public void update_post_list(Object[] obj)
        {
            post_list.update_el(new Post(Convert.ToInt32(obj[0]), obj[1].ToString()));
        }
        public void update_client_list(Object[] obj)
        {
            client_List.update_el(new Client(
                Convert.ToInt32(obj[0]),
                obj[1].ToString(),
                obj[2].ToString(),
                obj[3].ToString(),
                Convert.ToInt32(obj[4]),
                Convert.ToInt32(obj[5]),
                obj[6].ToString()
                ));
        }
        public class Client : Id
        {
            public int clientID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string LastName { get; set; }
            public int driversLicense { get; set; }
            public int passportNS { get; set; }
            public string phone { get; set; }

            public Client(int clientID, string name, string surname, string lastName, int driversLicense, int passportNS, string phone)
            {
                this.clientID = clientID;
                Name = name;
                Surname = surname;
                LastName = lastName;
                this.driversLicense = driversLicense;
                this.passportNS = passportNS;
                this.phone = phone;
            }
            public int id()
            {
                return this.clientID;
            }
            public List<String> mass_s()
            {
                List<String> array = new List<String>();
                array.Add(clientID.ToString());
                array.Add(Name);
                array.Add(Surname);
                array.Add(LastName);
                array.Add(driversLicense.ToString());
                array.Add(passportNS.ToString());
                array.Add(phone);
                return array;
            }
        }
        public class Automobil : Id
        {
            public int automobilID { get; set; }
            public string Name { get; set; }
            public int VIN { get; set; }

            public Automobil(int automobilID, string name, int vIN)
            {
                this.automobilID = automobilID;
                Name = name;
                VIN = vIN;
            }
            public int id()
            {
                return this.automobilID;
            }
        }
        public class Insurancesheet : Id
        {

            public int insurancesheetID { get; set; }
            public int clientID { get; set; }
            public int emploeeID { get; set; }
            public int automobilID { get; set; }
            public string date { get; set; }

            public Insurancesheet(int insurancesheetID, int clientID, int emploeeID, int automobilID, string date)
            {
                this.insurancesheetID = insurancesheetID;
                this.clientID = clientID;
                this.emploeeID = emploeeID;
                this.automobilID = automobilID;
                this.date = date;
            }
            public int id()
            {
                return this.insurancesheetID;
            }
            public List<String> mass_s()
            {
                List<String> array = new List<String>();
                array.Add(insurancesheetID.ToString());
                array.Add(clientID.ToString());
                array.Add(emploeeID.ToString());
                array.Add(automobilID.ToString());
                array.Add(date);
                return array;
            }
        }
        public class Employee : Id
        {
            public int employeeId { get; set; }
            public string name { get; set; }

            public string surname { get; set; }

            public string lastName { get; set; }

            public int postId { get; set; }
            public Employee(int employeeId, string name, string surname, string lastName, int postId)
            {
                this.employeeId = employeeId;
                this.name = name;
                this.surname = surname;
                this.lastName = lastName;
                this.postId = postId;
            }
            public int id()
            {
                return this.employeeId;
            }
        }
        public class Post : Id
        {
            public int postId { get; set; }
            public string postName { get; set; }

            public Post(int postId, string postName)
            {
                this.postId = postId;
                this.postName = postName;
            }
            public int id()
            {
                return this.postId;
            }
            public List<String> mass_s()
            {
                List<String> array = new List<String>();
                array.Add(postId.ToString());
                array.Add(postName);
                return array;
            }

        }
        interface Id
        {
            int id();
        }
        interface IList<T>
        {
            void add_el(T obj);
            void delete_el(int id);
            void update_el(T obj);
            Object select_el(T obj);
        }
        public class Client_list : IList<Client>
        {
            private List<Client> client_list;
            private static Client_list one;

            private Client_list()
            {
                client_list = new List<Client>();
            }
            public static Client_list get_instanse()
            {
                if (one == null)
                {
                    one = new Client_list();
                }
                return one;
            }
            public void add_el(Client client)
            {
                this.client_list.Add(client);
            }
            public void delete_el(int id)
            {
                this.client_list.RemoveAll(client => client.id() == id);
            }
            public void update_el(Client id)
            {
                Client old_client = this.client_list.Find(Client => Client.id() == id.id());
                old_client.clientID = id.clientID;
                old_client.Name = id.Name;
                old_client.Surname = id.Surname;
                old_client.LastName = id.LastName;
                old_client.driversLicense = id.driversLicense;
                old_client.passportNS = id.passportNS;
                old_client.phone = id.phone;
            }
            public Object select_el(Client obj)
            {
                return 1;
            }
            public List<List<string>> mass_klient()
            {
                List<List<string>> mass = new List<List<string>>();
                foreach (Client i in this.client_list)
                {
                    mass.Add(i.mass_s());
                }
                return mass;
            }
        }
        public class Insurancesheet_list : IList<Insurancesheet>
        {
            private List<Insurancesheet> insurancesheet_list;
            private static Insurancesheet_list one;

            private Insurancesheet_list()
            {
                insurancesheet_list = new List<Insurancesheet>();
            }
            public static Insurancesheet_list get_instanse()
            {
                if (one == null)
                {
                    one = new Insurancesheet_list();
                }
                return one;
            }
            public void add_el(Insurancesheet insurancesheet)
            {
                this.insurancesheet_list.Add(insurancesheet);
            }
            public void delete_el(int id)
            {
                this.insurancesheet_list.RemoveAll(insurancesheet => insurancesheet.id() == id);
            }
            public void update_el(Insurancesheet id)
            {
                Insurancesheet old_client = this.insurancesheet_list.Find(Insurancesheet => Insurancesheet.id() == id.id());
                old_client.clientID = id.clientID;
                old_client.insurancesheetID= id.insurancesheetID;
                old_client.emploeeID = id.emploeeID;
                old_client.automobilID = id.automobilID;
                old_client.date = id.date;
            }
            public Object select_el(Insurancesheet obj)
            {
                return 1;
            }
            public List<List<string>> mass_insurancesheet()
            {
                List<List<string>> mass = new List<List<string>>();
                foreach (Insurancesheet i in this.insurancesheet_list)
                {
                    mass.Add(i.mass_s());
                }
                return mass;
            }
        }
        public class Post_list : IList<Post>
        {
            private List<Post> post_list;
            private static Post_list one;
            private Post_list()
            {
                post_list = new List<Post>();
            }
            public static Post_list get_instanse()
            {
                if (one == null)
                {
                    one = new Post_list();
                }
                return one;
            }

            public void add_el(Post post)
            {
                this.post_list.Add(post);
            }
            public void delete_el(int id)
            {
                this.post_list.RemoveAll(post => post.id() == id);
            }
            public void update_el(Post id)
            {
                Post old_client = this.post_list.Find(Post => Post.id() == id.id());
                old_client.postId = id.postId;
                old_client.postName = id.postName;

            }
            public Object select_el(Post obj)
            {
                return 1;
            }
            public List<List<string>> mass_post()
            {
                List<List<string>> mass = new List<List<string>>();
                foreach (Post i in this.post_list)
                {
                    mass.Add(i.mass_s());
                }
                return mass;
            }

        }

    }
}
