package com.example.task_2;

import android.os.Bundle;

import com.example.task_2.city.City;
import com.example.task_2.city.Repository;
import com.example.task_2.helpers.Helpers;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

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
                Snackbar.make(view, Helpers.bundle2string(appBundle), Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
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
                appBundle.putString("ratingName", (String)parent.getAdapter().getItem(position));
                Log.i(TAG, Helpers.bundle2string(appBundle));
            }
        });
    }
}