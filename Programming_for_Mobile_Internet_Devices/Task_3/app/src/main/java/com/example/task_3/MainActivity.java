package com.example.task_3;

import android.content.Intent;
import android.os.Bundle;

import com.example.task_3.food.FoodGenerator;
import com.example.task_3.food.FoodItem;
import com.example.task_3.food.Fruit;
import com.example.task_3.food.Vegetable;
import com.example.task_3.recycler_view.FoodItemViewHolder;
import com.example.task_3.recycler_view.FoodViewAdapter;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;
import com.google.gson.Gson;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.util.Log;
import android.view.View;


public class MainActivity extends AppCompatActivity {
    private static final String TAG = "MainActivity";
    private FoodViewAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);


        // retrieve RecyclerView
        RecyclerView recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        // Creates an adapter
        adapter = new FoodViewAdapter(this, FoodGenerator.generateFoodItems());
        // Puts an adapter on RecyclerView
        recyclerView.setAdapter(adapter);
        // Inserts a view manager
        recyclerView.setLayoutManager(new LinearLayoutManager(this));


        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                adapter.setFoodItems(FoodGenerator.generateFoodItems());
                Snackbar.make(view, String.format("Number of elements %d", adapter.getItemCount()), Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

    }


    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        Bundle appBundle = null;
        String jsonMyObject;
        FoodItem foodItem = null;
        int position = -1;
        int foodItemType = -1;

        appBundle = data.getExtras();

        if (appBundle != null) {
            position = appBundle.getInt("position");
            foodItemType = appBundle.getInt("foodItemType");
            jsonMyObject = appBundle.getString("foodItem");

            switch (foodItemType) {
                case FoodItem.FoodItemType.Fruit:
                    foodItem = new Gson().fromJson(jsonMyObject, Fruit.class);
                    break;
                case FoodItem.FoodItemType.Vegetable:
                    foodItem = new Gson().fromJson(jsonMyObject, Vegetable.class);
                    break;
                default:
                    break;
            }
            adapter.updateFoodItemOnList(foodItem, position);
        }
        Log.i(TAG, "res");
    };

}