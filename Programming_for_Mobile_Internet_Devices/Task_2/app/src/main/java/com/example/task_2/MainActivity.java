package com.example.task_2;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ((Button)findViewById(R.id.buttonSubmitt)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent customIntent = new Intent(MainActivity.this, MainActivity2.class);
                Bundle myDataTable = new Bundle();
                myDataTable.putString("name", ((EditText) findViewById(R.id.editTextName)).getText().toString());
                customIntent.putExtras(myDataTable);
                startActivity(customIntent);
            }
        });

    }
}