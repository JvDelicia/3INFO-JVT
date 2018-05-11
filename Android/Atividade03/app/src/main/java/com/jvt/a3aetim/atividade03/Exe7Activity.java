package com.jvt.a3aetim.atividade03;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class Exe7Activity extends AppCompatActivity {

	TextView txt;
	Button btn;
	EditText etxt;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_exe7);

		TextView txt  = (TextView)findViewById(R.id.textView);
		EditText etxt  = (EditText) findViewById(R.id.editText);

		byte resp = 0;
		boolean rep = true;
		double total = 0;
		while(rep) {
			total += calculo();
			System.out.print("Deseja inserir mais um cômodo? Sim = 1 ou Não = 0: ");
			resp = reader.nextByte();
			if(resp == 0)
				rep = false;
		}
		System.out.print("A área total da moradia é: " + total + "m².");
		System.exit(0);
	}

	public double calculo() {
		double comp, larg, area, comod;
		txt.setText(R.string.pedNumCom);
		comod = Double.parseDouble(etxt.getText().toString());
		txt.setText("");
		txt.setText(R.string.compCom);
		comp = Double.parseDouble(etxt.getText().toString());
		txt.setText("");
		txt.setText(R.string.largCom);
		larg = Double.parseDouble(etxt.getText().toString());
		txt.setText("");

		area = comp * larg;

		System.out.println("O cômodo " + comod + " possui: " + area + "m²");
		return  area;
	}
}
