// 



using System;
using System.Collections.Generic;

namespace labs
{
    class Lab2Singleton: Lab
    {
        public void Run() {
            getRepositories();
            getStars();   
        }

        private void getRepositories() {
            Console.WriteLine("\nGET REPOSITORIES");
            GithubRestApi restApi = new GithubRestApi();
            restApi.getBestUsers();
        }

        private void getStars() {
            Console.WriteLine("\nGET STARS");
            GithubRestApi restApi = new GithubRestApi();
            restApi.getBestUsers();
        }
    }

    class GithubRestApi
    {
        private String host;
        private List<int> bestUserIds;
        List<int> numbers = new List<int>();


        public GithubRestApi()
        {
            
            this.host = "https://api.github.com";
            this.bestUserIds = new List<int>();

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                this.bestUserIds.Add(random.Next());
            }
        }

        public void getBestUsers()
        {
            foreach (int userId in bestUserIds) {
                this.makeCall("/user/"+userId);
            }
        }

        private void makeCall(String path)
        {
            Console.WriteLine(host + path);
        }
    }
}
