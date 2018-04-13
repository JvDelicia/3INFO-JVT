package android.aplicativo01;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class DiscountActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_discount);

        Intent intent = getIntent();
        String msg = intent.getStringExtra(main_activity.EXTRA_MESSAGE);

        TextView txV_mesagem  = (TextView)findViewById(R.id.txV_mensagem2);
        txV_mesagem.setText(msg);
    }

    private void calcular(View view) {
        EditText edT_valor = (EditText)findViewById(R.id.edT_valor);
        EditText edT_codigo = (EditText)findViewById(R.id.edT_codigo);
        TextView txV_final = (TextView)findViewById(R.id.txV_final);

        Double valor = Double.parseDouble(edT_valor.getText().toString());
        Byte codigo = Byte.parseByte(edT_codigo.getText().toString());
        Double preco; // valor final com desconto.

        switch(codigo) {
            case 1:
                preco = valor - (valor * 0.05);
                txV_final.setText(preco.toString());
                break;
            case 2:
                preco = valor - (valor * 0.1);
                txV_final.setText(preco.toString());
                break;
            case 3:
                preco = valor - (valor * 0.2);
                txV_final.setText(preco.toString());
                break;
            case 4:
                preco = valor - (valor * 0.5);
                txV_final.setText(preco.toString());
                break;
            default:
                txV_final.setText(valor.toString());
                break;
        }
    }
}