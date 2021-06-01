package com.example.task_2;

import android.os.Bundle;

import com.example.task_2.city.City;
import com.example.task_2.city.CityAdapter;
import com.example.task_2.city.CitySource;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.view.View;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivity2 extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        // create a data list
        ArrayList<City> cities = CitySource.generateItemsList(); // function to get a list of items

        // Create a personal list adapter
        CityAdapter adapter =  new  CityAdapter(this, cities);

        // extract ListView
        ListView itemsListView = findViewById(R.id.listViewCities);
        // set adapter
        itemsListView.setAdapter(adapter);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });
    }
}