using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Windows.Forms;

namespace AdventureGame
{
    class DatabaseCalls
    {
        private int USERID, CHARACTERID;

        public bool isUserValid(string userName, string userPassword)
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var loginQuery = from valid in dbcontext.userTables
                             where valid.username == userName &&
                                   valid.password == userPassword
                             select valid;

            if (loginQuery.Any())
            {
                dbcontext.Dispose();
                changeUser(userName, userPassword);
                return true;

            }
            else
            {
                dbcontext.Dispose();
                return false;
            }

        }

        private void changeUser(string userName, string userPassword)
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var idQuery = (from user in dbcontext.userTables
                           where user.username == userName &&
                                 user.password == userPassword
                           select user).SingleOrDefault();

            var objectQuery = (from obj in dbcontext.idTables
                               where obj.objectID == "userID"
                               select obj).SingleOrDefault();

            objectQuery.ID = idQuery.ID;

            dbcontext.SaveChanges();

            dbcontext.Dispose();
        }

        public bool accountCheck(string userName)
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var checkQuery = from check in dbcontext.userTables
                             where check.username == userName
                             select check;

            if(checkQuery.Any())
            {
                dbcontext.Dispose();
                return false;
            }
            else
            {
                dbcontext.Dispose();
                return true;
            }
        }

        public void createUser(string userName, string userPassword)
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            userTable data = new userTable
            {
                password = userPassword,
                username = userName
            };


            dbcontext.userTables.Add(data);
            dbcontext.SaveChanges();
            dbcontext.Dispose();
        }

        private void getUserID()
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var idQuery = (from id in dbcontext.idTables
                           where id.objectID == "userID"
                           select id.ID).Single();
            USERID = idQuery.Value;
            dbcontext.Dispose();
        }

        public bool userHasCharacter()
        {
            getUserID();
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var characterQuery = from character in dbcontext.characterTables
                                 where character.userID == USERID
                                 select character;

            if(characterQuery.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void createCharacter(string characterName, string characterRace, string characterClass, int strength, int constitution, int dexterity, int charisma, int wisdom, int intelligence)
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            int maxHP = 0, maxMana = 0, maxStamina = 0;

            if (characterRace == "Human")
            {
                charisma += 2;
                maxStamina += 25;
            }
            else if (characterRace == "Elf")
            {
                wisdom += 2;
                maxMana += 25;
            }
            else if (characterRace == "Orc")
            {
                strength += 2;
                maxHP += 25;
            }

            if (characterClass == "Warrior")
            {
                constitution += 2;
                maxHP += 25;
            }
            else if (characterClass == "Sorcerer")
            {
                intelligence += 2;
                maxMana += 25;
            }
            else if (characterClass == "Ranger")
            {
                dexterity += 2;
                maxStamina += 25;
            }
            else if (characterClass == "Cleric")
            {
                wisdom += 2;
                maxMana += 25;
            }

            maxHP += 8 * constitution;
            maxMana += 8 * wisdom;
            maxStamina += 8 * charisma;

            getUserID();

            characterTable data = new characterTable
            {
                Name = characterName,
                Race = characterRace,
                Class = characterClass,
                Level = 1,
                Experience = 0,
                Strength = strength,
                Constitution = constitution,
                Dexterity = dexterity,
                Charisma = charisma,
                Wisdom = wisdom,
                Intelligence = intelligence,
                MaxHP = maxHP,
                MaxMana = maxMana,
                MaxStamina = maxStamina,
                userID = USERID
            };

            dbcontext.characterTables.Add(data);
            dbcontext.SaveChanges();
            dbcontext.Dispose();
        }

        public void deleteCharacter()
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            getUserID();

            var query = (from row in dbcontext.characterTables
                         where row.userID == USERID
                         select row).FirstOrDefault();

            if (query != null)
            {
                dbcontext.characterTables.Remove(query);
                dbcontext.SaveChanges();
                dbcontext.Dispose();
            }
        }

        public void getCharacter(ref string characterName, ref string characterClass, ref string characterRace,
          ref int level, ref int experience, ref int strength, ref int constitution, ref int dexterity, 
          ref int charisma, ref int wisdom, ref int intelligence, ref int hp, ref int mana, ref int stamina)
        {
            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            getUserID();

            var characterQuery = ( from row in dbcontext.characterTables
                                   where row.userID == USERID
                                   select row).FirstOrDefault();

            characterName = characterQuery.Name;
            characterClass = characterQuery.Class;
            characterRace = characterQuery.Race;
            level = characterQuery.Level;
            experience = characterQuery.Experience;
            strength = characterQuery.Strength;
            constitution = characterQuery.Constitution;
            dexterity = characterQuery.Dexterity;
            charisma = characterQuery.Charisma;
            wisdom = characterQuery.Wisdom;
            intelligence = characterQuery.Intelligence;
            hp = characterQuery.MaxHP;
            mana = characterQuery.MaxMana;
            stamina = characterQuery.MaxStamina;

            changeCharacter();
        }

        private void changeCharacter()
        {
            getUserID();

            AdventureDatabaseEntities dbcontext = new AdventureDatabaseEntities();

            var idQuery = (from character in dbcontext.characterTables
                           where character.userID == USERID
                           select character).SingleOrDefault();

            var objectQuery = (from obj in dbcontext.idTables
                               where obj.objectID == "characterID"
                               select obj).SingleOrDefault();

            objectQuery.ID = idQuery.ID;

            dbcontext.SaveChanges();

            dbcontext.Dispose();
        }
    }
}
