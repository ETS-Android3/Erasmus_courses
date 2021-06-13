package com.example.task_3.food;

public class Fruit extends FoodItem {
    public Fruit(String name, float price, float quantity, float sweetnessIndex) {
        super(name, price, quantity, FoodItemType.Fruit);
        this.sweetnessIndex = sweetnessIndex;
    }

    private float sweetnessIndex;

    public float getSweetnessIndex() {
        return sweetnessIndex;
    }

    public String getSweetnessIndexStr() {
        return String.valueOf(sweetnessIndex);
    }

    public void setSweetnessIndex(float sweetnessIndex) {
        this.sweetnessIndex = sweetnessIndex;
    }

}
