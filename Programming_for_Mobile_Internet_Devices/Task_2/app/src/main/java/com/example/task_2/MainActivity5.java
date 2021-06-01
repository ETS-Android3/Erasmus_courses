package com.example.task_2;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.example.task_2.helpers.Helpers;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

public class MainActivity5 extends AppCompatActivity {
    private static final String TAG = "MainActivity5";
    Bundle appBundle = null;

    private void updateLabels(Bundle bundle){
        ((TextView)findViewById(R.id.activity1UserName)).setText(bundle.getString("activity1UserName"));
        ((TextView)findViewById(R.id.activity2CityName)).setText(bundle.getString("activity2CityName"));
        ((TextView)findViewById(R.id.activity2CityPostCode)).setText(bundle.getString("activity2CityPostCode"));
        ((TextView)findViewById(R.id.activity3RatingName)).setText(bundle.getString("activity3RatingName"));
        ((TextView)findViewById(R.id.activity4UserName)).setText(bundle.getString("activity4UserName"));
        ((TextView)findViewById(R.id.activity4CityName)).setText(bundle.getString("activity4CityName"));
        ((TextView)findViewById(R.id.activity4CityPostCode)).setText(bundle.getString("activity4CityPostCode"));
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main5);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        appBundle = getIntent().getExtras();
        updateLabels(appBundle);
        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, Helpers.bundle2string(appBundle), Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });

    }
}