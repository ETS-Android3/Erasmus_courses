package com.example.task_3.food;

import java.util.ArrayList;

public class FoodGenerator {
    public static ArrayList<FoodItem> generateFoodItems() {
        int maxNumberOfItems = 50;
        int numberOfItems = (int)Math.round(Math.random()*(float)maxNumberOfItems);
        return generateFoodItems(numberOfItems);
    }

    public static ArrayList<FoodItem> generateFoodItems(int len) {
        ArrayList<FoodItem> foodItems = new ArrayList<FoodItem>();
        for (int idx = 0; idx < len; idx++) {
            double rand = Math.random();
            double randClass = Math.random();
            float price = (float)Math.round((float)(rand*100*5))/100f;
            float quantity = (float)((int)(rand*1000));
            if (randClass > 0.5) {
                String name = String.format("f%d", idx);
                float sweetnesIdx = (float)Math.round((float)(rand*100*10))/100.0f;
                Fruit fruit = new Fruit(name, price, quantity, sweetnesIdx);
                foodItems.add((FoodItem)fruit);
            } else {
                String name = String.format("v%d", idx);
                Vegetable vegetable = new Vegetable(name, price, quantity);
                foodItems.add((FoodItem)vegetable);
            }
        }
        return foodItems;
    }

}
