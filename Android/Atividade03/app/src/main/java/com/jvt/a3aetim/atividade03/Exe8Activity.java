package com.jvt.a3aetim.atividade03;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class Exe8Activity extends AppCompatActivity {
	TextView textView2;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_exe8);
		TextView txt  = (TextView)findViewById(R.id.textView2);

		int i = 0, j = 2;
		int[] nac = new int[15];

		nac[0] = 1;
		txt.setText(nac[0] + ", ");
		nac[1] = 1;
		txt.setText(nac[1] + ", ");

		while (i < (nac.length - 2)) {
			nac[j] = nac[j - 1] + nac[j - 2];
			if (j == 14) {
				txt.setText(nac[j] + ".");
			} else if (j < 14){
				txt.setText(nac[j] + ", ");
			}
			j++;
			i++;
		}
	}
}
