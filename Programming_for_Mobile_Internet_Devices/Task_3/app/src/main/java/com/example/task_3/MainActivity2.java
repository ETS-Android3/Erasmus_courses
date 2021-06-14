package com.example.task_3;

import android.content.Intent;
import android.os.Bundle;

import com.example.task_3.food.FoodItem;
import com.example.task_3.food.Fruit;
import com.example.task_3.food.Vegetable;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;
import com.google.gson.Gson;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.text.TextUtils;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import static java.lang.Boolean.FALSE;
import static java.lang.Boolean.TRUE;

public class MainActivity2 extends AppCompatActivity {
    private static final String TAG = "MainActivity2";
    Bundle appBundle = null;
    FoodItem foodItem = null;
    int foodItemType = -1;
    int position = -1;
    FloatingActionButton fab = null;
    EditText detailsPopNumberOfItems = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        detailsPopNumberOfItems = findViewById(R.id.detailsPopNumberOfItems);

        fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (isPopNumberFieldValid()){
                    finish();
                } else {
                    Snackbar.make(view, "Sorry value not valid", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
                }
            }
        });
//        fab.setEnabled(false);


        appBundle = getIntent().getExtras();

        String jsonMyObject;
        if (appBundle != null) {
            position = appBundle.getInt("position");
            foodItemType = appBundle.getInt("foodItemType");
            jsonMyObject = appBundle.getString("foodItem");

            switch (foodItemType){
                case FoodItem.FoodItemType.Fruit:
                    foodItem = new Gson().fromJson(jsonMyObject, Fruit.class);
                    updateCoreData();
                    updateFruitData();
                    break;
                case FoodItem.FoodItemType.Vegetable:
                    foodItem = new Gson().fromJson(jsonMyObject, Vegetable.class);
                    updateCoreData();
                    break;
                default:
                    break;
            }
        }

//        detailsPopNumberOfItems.setOnFocusChangeListener(new View.OnFocusChangeListener() {
//            @Override
//            public void onFocusChange(View v, boolean hasFocus) {
//                validatePopNumberField();
//            }
//        });



    }

    @Override
    public void finish() {
        // Prepare data intent
        Intent customIntent = new Intent();
        int popItemsNumber = Integer.valueOf(detailsPopNumberOfItems.getText().toString());
        foodItem.setQuantity(foodItem.getQuantity()-popItemsNumber);
        customIntent.putExtra("foodItemType", foodItem.getFoodTypeInt());
        customIntent.putExtra("foodItem", new Gson().toJson(foodItem));
        customIntent.putExtra("position", position);
        setResult(RESULT_OK, customIntent);
        super.finish();
    }

    private void updateFruitData() {
        LinearLayout additionalDetails = findViewById(R.id.additionalDetails);
        additionalDetails.setVisibility(View.VISIBLE);
        TextView sweetnessIndex = findViewById(R.id.sweetnessIndex);
        sweetnessIndex.setText(((Fruit)foodItem).getSweetnessIndexStr());

    }

    private void updateCoreData(){
        TextView name = findViewById(R.id.name);
        TextView price = findViewById(R.id.price);
        TextView quantity = findViewById(R.id.quantity);
        TextView type = findViewById(R.id.type);
        name.setText(foodItem.getName());
        price.setText(foodItem.getPriceStr());
        quantity.setText(foodItem.getQuantityStr());
        type.setText(foodItem.getFoodTypeName());

        LinearLayout additionalDetails = findViewById(R.id.additionalDetails);
        additionalDetails.setVisibility(View.GONE);

        ((ImageView) findViewById(R.id.simpleImageView)).setImageResource(R.drawable.tomato);
        int drawableId = getResources().getIdentifier(foodItem.getImageName(), "drawable", getPackageName());
        ((ImageView) findViewById(R.id.simpleImageView)).setImageResource(drawableId);

    }

    private boolean isPopNumberFieldValid(){
        if (!TextUtils.isEmpty(detailsPopNumberOfItems.getText().toString())){
            int popItemsNumber = Integer.valueOf(detailsPopNumberOfItems.getText().toString());
            if(foodItem!=null && fab !=null && foodItem.getQuantity()>=popItemsNumber){
                return TRUE;
            }
        }
        return FALSE;
    }
}