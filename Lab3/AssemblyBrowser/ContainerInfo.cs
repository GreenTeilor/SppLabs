﻿using System.Collections.Generic;

namespace AssemblyBrowserLib
{
    public abstract class ContainerInfo : Member
    {
        public ContainerInfo()
        {
            Members = new List<Member>();
        }

        // List of elements in namespace
        public List<Member> Members { get; set; }

        internal void AddMember(Member member)
        {
            Members.Add(member);
        }
    }
}
