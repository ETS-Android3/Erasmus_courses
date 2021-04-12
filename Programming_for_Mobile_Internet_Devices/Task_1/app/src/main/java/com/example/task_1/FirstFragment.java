package com.example.task_1;

import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.navigation.fragment.NavHostFragment;

import java.util.ArrayList;
import java.util.List;

public class FirstFragment extends Fragment {
    private static final String TAG = "FirstFragment";
    private List<String> notValidItems = new ArrayList<String>();
    private Button buttonSubmitt = null;
    private Spinner spinnerSpecialty = null;
    private ViewGroup firstFragmentViewGroup = null;

    private void initValidation() {
        ViewGroup root = firstFragmentViewGroup;
        Log.i(TAG, "XXX initValidation items count: "+ ((ViewGroup) root).getChildCount());
        for(int index = 0; index < ((ViewGroup) root).getChildCount(); index++) {
            View nextChild = ((ViewGroup) root).getChildAt(index);
            String itemName = root.getResources().getResourceEntryName(nextChild.getId());
            Log.i(TAG, "XXX initValidation " + itemName);
            if(itemName.startsWith("editText") || itemName.startsWith("spinner")){
//                updateNotValidItems(itemName, Boolean.FALSE);
                notValidItems.add(itemName);
            }
        }
        Log.i(TAG, "XXX initValidation " + notValidItems);

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
        Log.i(TAG, "AAA updateNotValidItems " + notValidItems);
        buttonSubmitt.setEnabled(notValidItems.isEmpty());
    }

    private void validEditTextItem(View view){
        String itemName = view.getResources().getResourceEntryName(view.getId());
//        Log.i(TAG, "YYY validItem " + itemName);
        if(itemName.startsWith("editText")) {
            EditText mEdit = (EditText)view;
            Boolean isValid = Boolean.FALSE;
            if(itemName.equals("editTextFirstName") || itemName.equals("editTextLastName")) {
                String value = mEdit.getText().toString();
                String pattern = "^[A-Z][a-z]+";
                isValid = value.matches(pattern);
                updateNotValidItems(itemName, isValid);
                Log.i(TAG, "YYY itemName " + itemName + " value " + value + " isValid " + isValid);
            }
            if(itemName.equals("editTextFacultyNumber")) {
                String value = mEdit.getText().toString();
                String pattern = "^[0-9]*$";
                isValid = value.matches(pattern);
                updateNotValidItems(itemName, isValid);
                Log.i(TAG, "YYY itemName " + itemName + " value " + value + " isValid " + isValid);
            }
            if(!isValid){
                mEdit.setError("Not valid value");
            }
        }
    }

    @Override
    public View onCreateView(
            LayoutInflater inflater, ViewGroup container,
            Bundle savedInstanceState
    ) {
        // Inflate the layout for this fragment
        firstFragmentViewGroup = (ViewGroup) inflater.inflate(R.layout.fragment_first, null);
        initValidation();
        return inflater.inflate(R.layout.fragment_first, container, false);
    }

    public void onViewCreated(@NonNull View view, Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);

        buttonSubmitt = view.findViewById(R.id.buttonSubmitt);
        buttonSubmitt.setEnabled(Boolean.FALSE);
        spinnerSpecialty =  view.findViewById(R.id.spinnerSpecialty);
        buttonSubmitt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                NavHostFragment.findNavController(FirstFragment.this)
                        .navigate(R.id.action_FirstFragment_to_SecondFragment);
            }
        });

        view.findViewById(R.id.editTextFirstName).setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                if (!hasFocus) {
                    String itemName = v.getResources().getResourceEntryName(v.getId());
                    Log.i(TAG, itemName + " lost focus");
                    validEditTextItem(v);
                }
            }
        });

        view.findViewById(R.id.editTextLastName).setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                if (!hasFocus) {
                    String itemName = v.getResources().getResourceEntryName(v.getId());
                    Log.i(TAG, itemName + " lost focus");
                    validEditTextItem(v);
                }
            }
        });

        view.findViewById(R.id.editTextFacultyNumber).setOnFocusChangeListener(new View.OnFocusChangeListener() {
            @Override
            public void onFocusChange(View v, boolean hasFocus) {
                if (!hasFocus) {
                    String itemName = v.getResources().getResourceEntryName(v.getId());
                    Log.i(TAG, itemName + " lost focus");
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