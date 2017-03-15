// This file was generated by typhen-api

package battle

import (
	"errors"
	"github.com/shiwano/submarine/server/battle/lib/typhenapi"
)

var _ = errors.New

// Finish is a kind of TyphenAPI type.
type Finish struct {
	WinnerUserId *int64 `json:"winner_user_id" msgpack:"winner_user_id"`
	FinishedAt   int64  `json:"finished_at" msgpack:"finished_at"`
}

// Coerce the fields.
func (t *Finish) Coerce() error {
	return nil
}

// Bytes creates the byte array.
func (t *Finish) Bytes(serializer typhenapi.Serializer) ([]byte, error) {
	if err := t.Coerce(); err != nil {
		return nil, err
	}

	data, err := serializer.Serialize(t)
	if err != nil {
		return nil, err
	}

	return data, nil
}
