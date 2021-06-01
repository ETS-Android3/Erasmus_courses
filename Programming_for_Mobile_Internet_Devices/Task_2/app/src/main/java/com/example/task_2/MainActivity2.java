package com.example.task_2;

import android.content.Intent;
import android.os.Bundle;

import com.example.task_2.data.City;
import com.example.task_2.data.CityAdapter;
import com.example.task_2.data.CitySource;
import com.example.task_2.helpers.Helpers;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import java.util.ArrayList;

public class MainActivity2 extends AppCompatActivity {
    private static final String TAG = "MainActivity2";


    Bundle appBundle = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        FloatingActionButton fab = findViewById(R.id.fab);

        // create a data list
        ArrayList<City> cities = CitySource.generateItemsList(); // function to get a list of items

        // Create a personal list adapter
        CityAdapter adapter =  new  CityAdapter(this, cities);

        // extract ListView
        ListView itemsListView = findViewById(R.id.listViewCities);
        // set adapter
        itemsListView.setAdapter(adapter);

        appBundle = getIntent().getExtras();

        itemsListView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                appBundle.putString("cityName", ((City)parent.getAdapter().getItem(position)).getName());
                appBundle.putInt("cityPostCode", ((City)parent.getAdapter().getItem(position)).getPostCode());
                Log.i(TAG, Helpers.bundle2string(appBundle));
            }
        });
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent customIntent = new Intent(MainActivity2.this, MainActivity3.class);
                customIntent.putExtras(appBundle);
                startActivity(customIntent);
            }
        });
    }
}