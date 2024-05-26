using System.Collections.Generic;
using Wheel_of_Luck.Models;

namespace Wheel_of_Luck.Scripts.Common
{
    public class RewardsConfigurations
    {
        public static List<RewardModel> Config = new ()
        {
            new () {Amount = 10, Consumable = true, Type = "coin", Priority = 10},
            new () {Amount = 20, Consumable = true, Type = "coin", Priority = 0},
            new () {Amount = 30, Consumable = true, Type = "coin", Priority = 20},
            new () {Amount = 40, Consumable = true, Type = "coin", Priority = 0},
            new () {Amount = 50, Consumable = true, Type = "coin", Priority = 3},
            new () {Amount = 60, Consumable = true, Type = "coin", Priority = 0},
            new () {Amount = 70, Consumable = true, Type = "coin", Priority = 0},
            new () {Amount = 80, Consumable = true, Type = "coin", Priority = 100},
            new () {Amount = 1, Consumable = true, Type = "diamond", Priority = 0},
            new () {Amount = 2, Consumable = true, Type = "diamond", Priority = 0},
            new () {Amount = 3, Consumable = true, Type = "diamond", Priority = 200},
            new () {Amount = 4, Consumable = true, Type = "diamond", Priority = 0},
            new () {Amount = 5, Consumable = true, Type = "diamond", Priority = 50},
            new () {Amount = 6, Consumable = true, Type = "diamond", Priority = 0},
            new () {Amount = 7, Consumable = true, Type = "diamond", Priority = 21},
            new () {Amount = 8, Consumable = true, Type = "diamond", Priority = 0},
            new () {Amount = 1, Consumable = false, Type = "cup", Priority = 101},
            new () {Amount = 1, Consumable = false, Type = "skin", Priority = 0},
        };
    }
}