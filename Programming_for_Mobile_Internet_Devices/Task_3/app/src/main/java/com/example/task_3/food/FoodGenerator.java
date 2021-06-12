package com.example.task_3.food;

import java.util.ArrayList;

public class FoodGenerator {
    public ArrayList<FoodItem> generateFoodItems() {
        int numberOfItems = 150;
        return generateFoodItems(numberOfItems);
    }

    public ArrayList<FoodItem> generateFoodItems(int len) {
        ArrayList<FoodItem> foodItems = new ArrayList<FoodItem>();
        for (int idx = 0; idx < len; idx++) {
            double rand = Math.random();
            float price = Math.round((float)rand*100*5)/100;
            float quantity = (float)((int)rand*1000);
            if (rand > 0.5) {
                String name = String.format("f%d", idx);
                float sweetnesIdx = (float)rand*10;
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
