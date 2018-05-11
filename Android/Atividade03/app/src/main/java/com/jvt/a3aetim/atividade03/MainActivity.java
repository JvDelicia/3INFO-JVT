package com.jvt.a3aetim.atividade03;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {


	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	}


	private void exe5(View view) {
		Intent intent = new Intent(this, Exe5Activity.class);
		startActivity(intent);
	}

	private void exe7(View view) {
		Intent intent = new Intent(this, Exe7Activity.class);
		startActivity(intent);
	}

	private void exe8(View view) {
		Intent intent = new Intent(this, Exe8Activity.class);
		startActivity(intent);
	}
}
