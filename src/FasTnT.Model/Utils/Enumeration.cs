﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FasTnT.Model.Utils
{
    public abstract class Enumeration : IComparable
    {
        public string DisplayName { get; private set; }
        public short Id { get; private set; }

        protected Enumeration() { }

        protected Enumeration(short id, string displayName)
        {
            Id = id;
            DisplayName = displayName;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration, new() => typeof(T).GetTypeInfo().GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly).Select(x => x.GetValue(new T())).Cast<T>();
        public static T GetByDisplayName<T>(string displayName) where T : Enumeration, new() => GetAll<T>().SingleOrDefault(x => x.DisplayName == displayName) ?? throw new Exception($"Invalid value for {typeof(T).Name} : '{displayName}'");
        public static T GetById<T>(short id) where T : Enumeration, new() => GetAll<T>().SingleOrDefault(x => x.Id == id) ?? throw new Exception($"Invalid ID for {typeof(T).Name} : {id}");
        public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);
        public override int GetHashCode() => 2108858624 + GetType().GetHashCode() + Id.GetHashCode();
        public override string ToString() => DisplayName;
        public override bool Equals(object obj) => (obj is Enumeration other) && GetType().Equals(obj.GetType()) && Id.Equals(other.Id);
    }
}
