package com.example.task_3.recycler_view;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.task_3.R;
import com.example.task_3.food.FoodItem;
import com.example.task_3.food.Fruit;
import com.google.android.material.snackbar.Snackbar;


import java.util.ArrayList;

public class FoodViewAdapter extends RecyclerView.Adapter<RecyclerView.ViewHolder> {
    private ArrayList<FoodItem> foodItems;

    public FoodViewAdapter(ArrayList<FoodItem> initFoodItems){
        this.foodItems = initFoodItems;
    }

    public void setFoodItems(ArrayList<FoodItem> foodItems) {
        this.foodItems = foodItems;
        this.notifyDataSetChanged();
    }


    @Override
    public RecyclerView.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        //retrieves the context where the RecyclerView is located
        Context context = parent.getContext();
        LayoutInflater inflater = LayoutInflater.from(context);

        View foodItemView;

        // Creates a viewHolder object
        switch (viewType){
            case FoodItem.FoodItemType.Fruit:
                foodItemView = inflater.inflate(R.layout.fruit_item_list_item_view, parent, false);
                return new FruitViewHolder((foodItemView));

            case FoodItem.FoodItemType.Vegetable:
                foodItemView = inflater.inflate(R.layout.vegetable_item_list_item_view, parent, false);
                return new FoodItemViewHolder((foodItemView));

            default:
                foodItemView = inflater.inflate(R.layout.food_item_list_item_view, parent, false);
                return new FoodItemViewHolder((foodItemView));
        }
    }
    // Associates data with the view
    @Override
    public void onBindViewHolder(@NonNull RecyclerView.ViewHolder holder, int position) {
        //With the current item from the collection
        FoodItem foodItem = foodItems.get(position);

        FoodItemViewHolder foodItemHolder = (FoodItemViewHolder)holder;
        // Sets the TextView value for basic fields
        foodItemHolder.setName(foodItem.getName());
        foodItemHolder.setPrice(String.valueOf(foodItem.getPrice()));
        foodItemHolder.setQuantity(String.valueOf(foodItem.getQuantity()));
        foodItemHolder.setType(foodItem.getFoodTypeName());
        switch (holder.getItemViewType()) {
            case FoodItem.FoodItemType.Fruit:
                ((FruitViewHolder) holder).setSweetnessIndex(((Fruit)foodItem).getSweetnessIndexStr());
                break;
            default:
                break;
        }
        // Puts a listener for pressing a list item
        holder.itemView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, foodItemHolder.getName().getText(), Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

    }
    //Returns the size of the collection
    @Override
    public int getItemCount() {
        return foodItems.size();
    }

    @Override
    public int getItemViewType(int position) {
        FoodItem foodItem = foodItems.get(position);

        return foodItem.getFoodTypeInt();
    }

}
