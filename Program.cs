using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //Collections to work with
      List<Artist> Artists = MusicStore.GetData().AllArtists;
      List<Group> Groups = MusicStore.GetData().AllGroups;

      //========================================================
      //Solve all of the prompts below using various LINQ queries
      //========================================================

      //There is 2 artists in this collection from Mount Vernon, what is their name and age?
      List<Artist> MountVernonArtists = Artists.Where(a => a.Hometown == "Mount Vernon").ToList();
      foreach (Artist a in MountVernonArtists)
      {
        System.Console.WriteLine($"#1: {a.ArtistName} {a.Age}");
      }
      //Who is the youngest artist in our collection of artists?
      Artist YoungestArtist = Artists.OrderBy(a => a.Age).First();
      System.Console.WriteLine($"#2: {YoungestArtist.ArtistName}: {YoungestArtist.Age}");

      //Display all artists with 'William' somewhere in their real name
      List<Artist> ArtistsWilliam = Artists.Where(a => a.RealName.Contains("William")).ToList();
      foreach (Artist a in ArtistsWilliam)
      {
        System.Console.WriteLine($"#3: {a.RealName}");
      }
      //Display the 3 oldest artist from Atlanta
      List<Artist> AllArtistsAtlanta = Artists.Where(a => a.Hometown == "Atlanta").OrderByDescending(a => a.Age).ToList();
      foreach (Artist a in AllArtistsAtlanta)
      {
        System.Console.WriteLine($"4b: {a.RealName} - {a.Age}");
      }


      List<Artist> ThreeOldestArtistsAtlanta = Artists.Where(a => a.Hometown == "Atlanta").OrderByDescending(a => a.Age).Take(3).ToList();
      foreach (Artist a in ThreeOldestArtistsAtlanta)
      {
        System.Console.WriteLine($"4a: {a.RealName} - {a.Age}");
        System.Console.WriteLine();
      }

      //(Optional) Display the Group Name of all groups that have members that are not from New York City
      // IEnumerable<Group> AllGroupsNotNY = Groups.Where(a => a.Members == "NewYork");


      //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
      // Console.WriteLine(Groups.Count);
  
    }
  }
}