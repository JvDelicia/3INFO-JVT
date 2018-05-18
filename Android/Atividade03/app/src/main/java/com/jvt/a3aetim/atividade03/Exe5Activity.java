package com.jvt.a3aetim.atividade03;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.EditText;
import android.widget.TextView;

public class Exe5Activity extends AppCompatActivity {
	TextView textView3;
	EditText etxt;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_exe5);

		TextView textView3  = (TextView)findViewById(R.id.textView3);
		TextView etxt  = (TextView)findViewById(R.id.editText2);

	}

	public void calc(){
		textView3.setText(R.string.numVolt);
		double numv = Double.parseDouble(etxt.getText().toString());
		textView3.setText("");

		textView3.setText(R.string.diaM);
		double dia = Double.parseDouble(etxt.getText().toString());
		textView3.setText("");

		double dist = ((Math.PI * dia) / 2) * numv;

		textView3.setText("A distância percorrida é: " + dist);
	}

}
