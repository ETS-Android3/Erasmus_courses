package com.example.task_3.food;

import java.util.EnumSet;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

public class FoodItem {

    public class FoodItemType {
        public static final int Default = 0;
        public static final int Vegetable = 1;
        public static final int Fruit = 2;

        private int value;

        public FoodItemType(int value) {
            this.value = value;
        }

        public int getValue() {
            return value;
        }

        public void setValue(int value) {
            this.value = value;
        }

        public String getName(){
            switch (getValue()){
                case Default:
                    return "Default";
                case Vegetable:
                    return "Vegetable";
                case Fruit:
                    return "Fruit";
                default:
                    return null;
            }
        }
    }

    private String name;
    private float price;
    private float quantity;
    private FoodItemType foodType;


    public FoodItem() {
        setFoodType(FoodItemType.Default);
    }

    public FoodItem(String name, float price, float quantity) {
        this();
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public FoodItem(String name, float price, float quantity, FoodItemType foodType) {
        setName(name);
        setPrice(price);
        setQuantity(quantity);
        setFoodType(foodType);
    }

    public FoodItem(String name, float price, float quantity, int foodType) {
        setName(name);
        setPrice(price);
        setQuantity(quantity);
        setFoodType(foodType);
    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public float getPrice() {
        return price;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public float getQuantity() {
        return quantity;
    }

    public void setQuantity(float quantity) {
        this.quantity = quantity;
    }

    public FoodItemType getFoodType() {
        return foodType;
    }

    public int getFoodTypeInt() {
        return foodType.getValue();
    }

    public String getFoodTypeName() {
        return foodType.getName();
    }

    public void setFoodType(FoodItemType foodType) {
        this.foodType = foodType;
    }

    public void setFoodType(int foodType) {
        this.foodType = new FoodItemType(foodType);
    }

}
