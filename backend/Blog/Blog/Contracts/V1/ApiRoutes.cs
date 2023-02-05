using System;
namespace Blog.Contracts.V1
{
    public class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = $"{Root}/{Version}";

        public static class Posts
        {
            public const string PostBase = $"{Base}/posts";

            public const string Create = PostBase;
            public const string Get = PostBase + "/{postId}";
            public const string GetAll = PostBase + "/all";
            public const string Update = PostBase + "/{postId}";
            public const string Delete = PostBase + "/{postId}";
        }
    }
}

