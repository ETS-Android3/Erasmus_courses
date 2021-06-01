package com.example.task_2;

import android.os.Bundle;

import com.example.task_2.helpers.Helpers;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.view.View;

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
    }
}