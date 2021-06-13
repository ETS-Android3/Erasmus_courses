package com.example.task_3.recycler_view;

import android.view.View;
import android.widget.TextView;

import androidx.annotation.NonNull;

import androidx.recyclerview.widget.RecyclerView;

import com.example.task_3.R;


public class FoodItemViewHolder extends RecyclerView.ViewHolder {
    private TextView name;
    private TextView type;
    private TextView price;
    private TextView quantity;

    public FoodItemViewHolder(@NonNull View itemView){
        super(itemView);
        name = itemView.findViewById(R.id.name);
        type = itemView.findViewById(R.id.type);
        price = itemView.findViewById(R.id.price);
        quantity = itemView.findViewById(R.id.quantity);
    }

    public TextView getName() {
        return name;
    }

    public void setName(String name) {
        this.name.setText(name);
    }

    public TextView getType() {
        return type;
    }

    public void setType(String type) {
        this.type.setText(type);
    }

    public TextView getPrice() {
        return price;
    }

    public void setPrice(String price) {
        this.price.setText(price);
    }

    public TextView getQuantity() {
        return quantity;
    }

    public void setQuantity(String quantity) {
        this.quantity.setText(quantity);
    }
}
