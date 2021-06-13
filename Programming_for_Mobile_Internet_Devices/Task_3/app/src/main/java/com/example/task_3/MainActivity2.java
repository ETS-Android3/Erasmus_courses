package com.example.task_3;

import android.content.Intent;
import android.os.Bundle;

import com.example.task_3.food.FoodItem;
import com.example.task_3.food.Fruit;
import com.example.task_3.food.Vegetable;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;
import com.google.gson.Gson;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.view.View;

public class MainActivity2 extends AppCompatActivity {
    private static final String TAG = "MainActivity2";
    Bundle appBundle = null;
    FoodItem foodItem = null;
    int foodItemType = -1;
    int position = -1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        appBundle = getIntent().getExtras();

        String jsonMyObject;
        if (appBundle != null) {
            position = appBundle.getInt("position");
            foodItemType = appBundle.getInt("foodItemType");
            jsonMyObject = appBundle.getString("foodItem");

            switch (foodItemType){
                case FoodItem.FoodItemType.Fruit:
                    foodItem = new Gson().fromJson(jsonMyObject, Fruit.class);
                    break;
                case FoodItem.FoodItemType.Vegetable:
                    foodItem = new Gson().fromJson(jsonMyObject, Vegetable.class);
                    break;
                default:
                    break;
            }
        }


        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
//                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
//                        .setAction("Action", null).show();
                finish();
            }
        });

    }

    @Override
    public void finish() {
        // Prepare data intent
        Intent customIntent = new Intent();
        foodItem.setQuantity(foodItem.getQuantity()/2);
        customIntent.putExtra("foodItemType", foodItem.getFoodTypeInt());
        customIntent.putExtra("foodItem", new Gson().toJson(foodItem));
        customIntent.putExtra("position", position);
        setResult(RESULT_OK, customIntent);
        super.finish();
    }
}