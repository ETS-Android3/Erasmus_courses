package com.example.task_1;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.navigation.fragment.NavHostFragment;

public class SecondFragment extends Fragment {
    TextView textViewFirstNameView = null;
    TextView textViewLastNameView = null;
    TextView textViewFacultyNumberView = null;
    TextView textViewSpecialtyView = null;

    private void putValuesToFields(String firstName, String  lastName, String  facultyNumber, String specialty){
        textViewFirstNameView.setText(firstName);
        textViewLastNameView.setText(lastName);
        textViewFacultyNumberView.setText(facultyNumber);
        textViewSpecialtyView.setText(specialty);
    }

    @Override
    public View onCreateView(
            LayoutInflater inflater, ViewGroup container,
            Bundle savedInstanceState
    ) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_second, container, false);
    }

    public void onViewCreated(@NonNull View view, Bundle savedInstanceState) {
        super.onViewCreated(view, savedInstanceState);
        textViewFirstNameView = view.findViewById(R.id.textViewFirstNameView);
        textViewLastNameView = view.findViewById(R.id.textViewLastNameView);
        textViewFacultyNumberView = view.findViewById(R.id.textViewFacultyNumberView);
        textViewSpecialtyView = view.findViewById(R.id.textViewSpecialtyView);
        view.findViewById(R.id.button_second).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                NavHostFragment.findNavController(SecondFragment.this)
                        .navigate(R.id.action_SecondFragment_to_FirstFragment);
            }
        });

        putValuesToFields("piersze", "imie", "51151547", "specjak");
    }
}