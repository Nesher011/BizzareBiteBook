﻿using BizzareBiteBook.Domain.Entities;

namespace BizzareBiteBook.Application.Common.Models;

public class LookupDto
{
    public int Id { get; init; }

    public string? Title { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<TodoList, LookupDto>();
            CreateMap<TodoItem, LookupDto>();
            CreateMap<Recipe, LookupDto>();
            CreateMap<Ingredient, LookupDto>();
            CreateMap<Step, LookupDto>();
        }
    }
}
