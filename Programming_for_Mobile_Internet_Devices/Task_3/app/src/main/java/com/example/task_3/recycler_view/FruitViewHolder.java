package com.example.task_3.recycler_view;

import android.view.View;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.task_3.R;


public class FruitViewHolder extends FoodItemViewHolder {
    private TextView sweetnessIndex;

    public FruitViewHolder(@NonNull View itemView){
        super(itemView);
        sweetnessIndex = itemView.findViewById(R.id.sweetnessIndex);
    }

    public TextView getSweetnessIndex() {
        return sweetnessIndex;
    }

    public void setSweetnessIndex(String sweetnessIndexVal) {
        this.sweetnessIndex.setText(sweetnessIndexVal);
    }

}
