﻿namespace CatsServer.Handlers
{
    using CatsServer.Data;
    using CatsServer.Infrastructure;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    public class AddCatHandler : IHandler
    {
        public int Order => 2;

        public Func<HttpContext, bool> Condition =>
            ctx => ctx.Request.Path.Value == "/cat/add";

        public RequestDelegate RequestHandler => async (context) =>
        {
            if (context.Request.Method == HttpMethod.Get)
            {
                context.Response.Redirect("/cats-add-form.html");
            }
            else if (context.Request.Method == HttpMethod.Post)
            {
                var formData = context.Request.Form;

                int.TryParse(formData["Age"], out int age);

                var cat = new Cat
                {
                    Name = formData["Name"],
                    Age = age,
                    Breed = formData["Breed"],
                    ImageUrl = formData["ImageUrl"],
                };

                try
                {
                    if (string.IsNullOrWhiteSpace(cat.Name)
                        || string.IsNullOrWhiteSpace(cat.Breed)
                        || string.IsNullOrWhiteSpace(cat.ImageUrl))
                    {
                        throw new InvalidOperationException(
                            "Invalid cat data.");
                    }
                    using var db = context.RequestServices.GetRequiredService<CatsDbContext>();

                    db.Add(cat);
                    await db.SaveChangesAsync();

                    context.Response.Redirect("/");
                }
                catch (System.Exception)
                {
                    await context.Response.WriteAsync(
                        "<h2>Invalid cat data!</h2>");
                    await context.Response.WriteAsync(
                        @"<a href=""/cat/add"">Back To The Form</a>");
                }
            }
        };
    }
}
