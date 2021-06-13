package com.example.task_3;

import android.os.Bundle;

import com.example.task_3.food.FoodGenerator;
import com.example.task_3.recycler_view.FoodItemViewHolder;
import com.example.task_3.recycler_view.FoodViewAdapter;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.View;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

        // retrieve RecyclerView
        RecyclerView recyclerView = (RecyclerView) findViewById(R.id.recyclerView);
        // Creates an adapter
        FoodViewAdapter adapter = new FoodViewAdapter(FoodGenerator.generateFoodItems());
        // Puts an adapter on RecyclerView
        recyclerView.setAdapter(adapter);
        // Inserts a view manager
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
    }

}