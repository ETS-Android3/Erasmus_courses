package com.example.task_3.food;

public class FoodItem {

    public enum FoodItemType {
        Default,
        Vegerable,
        Fruit
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
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.foodType = foodType;
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
        return foodType.ordinal();
    }

    public void setFoodType(FoodItemType foodType) {
        this.foodType = foodType;
    }

}
