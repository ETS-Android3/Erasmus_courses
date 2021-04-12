package com.example.task_1_1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {
    private static final String TAG = "MainActivity";
    private List<String> notValidItems = new ArrayList<String>();
    private Button buttonSubmitt = null;
    private Spinner spinnerSpecialty = null;


    private void initValidation() {
        View root = this.findViewById(android.R.id.content);
        Log.d(TAG, "XXX initValidation items count: "+ ((ViewGroup) root).getChildCount());
        for(int index = 0; index < ((ViewGroup) root).getChildCount(); index++) {
            try {
                View nextChild = ((ViewGroup) root).getChildAt(index);
                String itemName = root.getResources().getResourceEntryName(nextChild.getId());
                Log.d(TAG, "XXX initValidation " + itemName);
                if(itemName.startsWith("editText") || itemName.startsWith("spinner")){
//                    updateNotValidItems(itemName, Boolean.FALSE);
                    notValidItems.add(itemName);
                }
            } catch (Exception e){

            }
        }
        Log.d(TAG, "XXX initValidation " + notValidItems);

    }

    private void updateNotValidItems(String itemName, Boolean isValid){
        if(isValid){
            if(notValidItems.contains(itemName)){
                notValidItems.remove(itemName);
            }
        } else {
            if (!notValidItems.contains(itemName)) {
                notValidItems.add(itemName);
            }
        }
        Log.d(TAG, "AAA updateNotValidItems " + notValidItems);
        buttonSubmitt.setEnabled(notValidItems.isEmpty());
    }

    private void validEditTextItem(View view){
        String itemName = view.getResources().getResourceEntryName(view.getId());
//        Log.d(TAG, "YYY validItem " + itemName);
        if(itemName.startsWith("editText")) {
            EditText mEdit = (EditText)view;
            Boolean isValid = Boolean.FALSE;
            if(itemName.equals("editTextFirstName") || itemName.equals("editTextLastName")) {
                String value = mEdit.getText().toString();
                String pattern = "^[A-Z][a-z]+";
                isValid = value.matches(pattern);
                updateNotValidItems(itemName, isValid);
                Log.d(TAG, "YYY itemName " + itemName + " value " + value + " isValid " + isValid);
            }
            if(itemName.equals("editTextFacultyNumber")) {
                String value = mEdit.getText().toString();
                String pattern = "^[0-9]{10}$";
                isValid = value.matches(pattern);
                updateNotValidItems(itemName, isValid);
                Log.d(TAG, "YYY itemName " + itemName + " value " + value + " isValid " + isValid);
            }
            if(!isValid){
                mEdit.setError("Not valid value");
            }
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        spinnerSpecialty =  findViewById(R.id.spinnerSpecialty);
        initValidation();

        buttonSubmitt = findViewById(R.id.buttonSubmitt);
        buttonSubmitt.setEnabled(Boolean.FALSE);
        buttonSubmitt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent customIntent = new Intent(MainActivity.this, AnotherActivity.class);
                Bundle myDataTable = new Bundle();
                myDataTable.putString("firstName", ((EditText) findViewById(R.id.editTextFirstName)).getText().toString());
                myDataTable.putString("lastName", ((EditText) findViewById(R.id.editTextLastName)).getText().toString());
                myDataTable.putString("facultyNumber", ((EditText) findViewById(R.id.editTextFacultyNumber)).getText().toString());
                myDataTable.putString("specialty", (String) spinnerSpecialty.getSelectedItem());

                customIntent.putExtras(myDataTable);

                startActivity(customIntent);
            }
        });


        findViewById(R.id.editTextFirstName).setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                if (!hasFocus) {
                    String itemName = v.getResources().getResourceEntryName(v.getId());
                    Log.d(TAG, itemName + " lost focus");
                    validEditTextItem(v);
                }
            }
        });

        findViewById(R.id.editTextLastName).setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                if (!hasFocus) {
                    String itemName = v.getResources().getResourceEntryName(v.getId());
                    Log.d(TAG, itemName + " lost focus");
                    validEditTextItem(v);
                }
            }
        });

        findViewById(R.id.editTextFacultyNumber).setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                if (!hasFocus) {
                    String itemName = v.getResources().getResourceEntryName(v.getId());
                    Log.d(TAG, itemName + " lost focus");
                    validEditTextItem(v);
                }
            }
        });

        spinnerSpecialty.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                String itemName = view.getResources().getResourceEntryName(spinnerSpecialty.getId());
                updateNotValidItems(itemName, spinnerSpecialty.getSelectedItemPosition() != 0);
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });

    }
}