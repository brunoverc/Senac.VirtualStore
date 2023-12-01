﻿using System;
using Microsoft.OpenApi.Models;

namespace VirtualStore.API.Configuration
{
	public static class SwaggerConfig
	{
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "VirtualStore API",
                    Description = "Esta API é feita como parte do curso Programador de Sistemas SENAC",
                    Contact = new OpenApiContact()
                    {
                        Name = "Senac",
                        Email = "contato@go.senac.br"
                    }
                });
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("swagger/v1/swagger.json", "v1");
            });
        }
    }
}

