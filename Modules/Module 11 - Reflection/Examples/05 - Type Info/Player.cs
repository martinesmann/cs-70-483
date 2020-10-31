using System;

namespace Wincubate.Module11.Slide05
{
   public enum Position
   {
      Undefined,
      GoalKeeper,
      Defender,
      Midfielder,
      Attacker
   }

   public class Player
   {
      #region Properties
      public string Name
      {
         get
         {
            return m_Name;
         }
      }
      private string m_Name;

      public int BackNumber
      {
         get
         {
            return m_BackNumber;
         }
         set
         {
            m_BackNumber = value;
         }
      }
      private int m_BackNumber;

      public Position PreferredPosition
      {
         get
         {
            return m_PreferredPosition;
         }
      }
      private Position m_PreferredPosition;
      #endregion

      #region Methods
      public static bool IsAssigned( Player player )
      {
         return player.m_PreferredPosition != Position.Undefined;
      }

      public override string ToString()
      {
         string position =
            (PreferredPosition != Position.Undefined ?
               " plays " + PreferredPosition :
               "");

         return string.Format("Number {0} called {1}{2}",
            Name,
            BackNumber,
            position);
      }
      public void SetPosition(Position position)
      {
         m_PreferredPosition = position;
      }
      #endregion

      #region Constructors
      public Player(string name, int backNumber) : this( name, backNumber, Position.Undefined )
      {
      }

      public Player(string name, int backNumber, Position preferredPosition )
      {
         m_Name = name;
         m_BackNumber = backNumber;
         m_PreferredPosition = preferredPosition;
      }
      #endregion
   }
}
