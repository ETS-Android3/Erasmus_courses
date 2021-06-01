package com.example.task_2;

import android.content.Intent;
import android.os.Bundle;

import com.example.task_2.data.Repository;
import com.example.task_2.helpers.Helpers;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class MainActivity3 extends AppCompatActivity {
    private static final String TAG = "MainActivity3";
    Bundle appBundle = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main3);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        appBundle = getIntent().getExtras();

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent customIntent = new Intent(MainActivity3.this, MainActivity4.class);
                customIntent.putExtras(appBundle);
                startActivity(customIntent);
            }
        });

        String[] estimates = Repository.getItemsList();

        ArrayAdapter<String> estimatesAdapter = new ArrayAdapter<String>(
                this, // the context where the adapter will be used
                R.layout.layout_list_view_row_item_rating, // visual element for a row in ListView
                R.id.name, // visual element for displaying data
                estimates // data collection
        );
        // extract ListView
        ListView listView = findViewById(R.id.listView);
        // set adapter
        listView.setAdapter(estimatesAdapter);

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                appBundle.putString("activity3RatingName", (String)parent.getAdapter().getItem(position));
                Log.i(TAG, Helpers.bundle2string(appBundle));
            }
        });
    }
}